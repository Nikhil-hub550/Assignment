using Assignment.BusinessLogic.Interface;
using Assignment.DataAccess.Data;
using Assignment.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Assignment.Controllers
{
    
    [ApiController]
    [Route("api/users")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private IConfiguration _config;
        /// <summary>
        /// Default Contructor
        /// </summary>
        public UserController(IMapper mapper, IUserService userService, IConfiguration config) 
        {
            _mapper = mapper;
            _userService = userService;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async ValueTask<IActionResult> LoginAsync(LoginDto loginDto)
        {
            return Ok(await _userService.LoginAsync(loginDto));
        }

        [Route("CreateUser")]
        [HttpPost]
        public async ValueTask<IActionResult> CreateUserAsync([FromBody]CreateUserDto createUserDto)
        {
            var result = await _userService.CreateUserAsync(createUserDto);
            return Ok(result);
        }

        [Route("GetAll")]
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [Route("GetById")]
        [HttpGet]
      
        public async ValueTask<IActionResult> GetById(string id)
        {
           return Ok(await _userService.GetByIdAsync(id));
        }

        [Route("UpdateUser")]
        [HttpPut]
        public async ValueTask<IActionResult> UpdateData(UpdateUserDto updateUser)
        {
            return Ok(await _userService.UpdateAsync(updateUser));
        }

        [Route("DeleteUser")]
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(string id)
        {
            return Ok(await _userService.DeleteAsync(id));
        }
        [Route("Search")]
        [HttpGet]
        public async ValueTask<IActionResult> SearchUSersAsync([FromQuery] SearchDto searchDto)
        {
            return Ok(await _userService.SearchUsersAsync(searchDto));
        }
    }
}
