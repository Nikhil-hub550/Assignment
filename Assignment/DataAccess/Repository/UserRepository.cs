using Assignment.DataAccess.Data;
using Assignment.DataAccess.Interface;
using Assignment.DataAccess.Models;
using Assignment.DTOs;
using Assignment.ResponseType;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace Assignment.DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly BaxtureDbContext _dbContext;
        private readonly IConfiguration _configuration;
        public UserRepository(IMapper mapper, BaxtureDbContext dbContext, IConfiguration configuration)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async ValueTask<ResponseBase> CreateUser(CreateUserDto createUser)
        {            
            var result = _mapper.Map<User>(createUser);
            result.UserId = Guid.NewGuid();

            await _dbContext.AddAsync(result);
            await _dbContext.SaveChangesAsync();
            return new SuccessResponse();
        }

        public async ValueTask<ResponseBase> GetAllAsync()
        {
            var records = await _dbContext.Users.Where(x => x.RoleGroupId == 1).Include(x => x.Hobbies).ToListAsync();
            var result = _mapper.Map<List<GetAllUserDto>>(records);
            return new SuccessDataResponse(data: result);
        }

        public async ValueTask<ResponseBase> GetByIdAsync(Guid id)
        {
            var records = await _dbContext.Users.Include(x => x.Hobbies)
                                                .Where(x => x.UserId == id)
                                                .SingleOrDefaultAsync();
            if (records == null)
            {
                return new NotFound(message: "User does'nt exits");
            }
            if (records.UserId != id)
            {
                return new BadRequest();
            }
            var result = _mapper.Map<GetAllUserDto>(records);
            return new SuccessDataResponse(data: result);
        }

        public async ValueTask<ResponseBase> UpdateAsync(UpdateUserDto updateUser)
        {
            var model = await _dbContext.Users.Include(x => x.Hobbies).Where(x => x.UserId == Guid.Parse(updateUser.UserId))
                .FirstOrDefaultAsync();
            if (model == null)
                return new NotFound();

            var resultDto = _mapper.Map(updateUser, model);           
            _dbContext.Update(resultDto);
            await _dbContext.SaveChangesAsync();
            return new SuccessResponse();
        }

        public async ValueTask<ResponseBase> DeleteAsync(Guid id)
        {
            var model = await _dbContext.Users.Where(x => x.UserId == id)
                .FirstOrDefaultAsync();
            _dbContext.Remove<User>(model);
            _dbContext.SaveChanges();
            return new RecordNotFound();
        }

        public async ValueTask<ResponseBase> LoginAsync(LoginDto loginDto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Sectoken = new JwtSecurityToken(_configuration["Jwt:Issuer"],
              _configuration["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);  
            
            return new SuccessDataResponse(data:token);
        }

        public async ValueTask<ResponseBase> SearchUsersAsync(SearchDto searchParams)
        {
            try
            {   
                var query = _dbContext.Users.AsQueryable();               
                var pageSize = searchParams.PageSize > 0 ? searchParams.PageSize : 10;
                var pageNumber = searchParams.PageNumber > 0 ? searchParams.PageNumber : 1;

                var result = await query
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Include(x => x.Hobbies)
                    .ToListAsync();

                var mappedResult = _mapper.Map<List<GetAllUserDto>>(result);

                return new SuccessDataResponse(data: mappedResult);
            }
            catch (Exception ex)
            {                
                return new InternalServer("An error occurred while searching users");
            }
        }
    }
}
