using Assignment.BusinessLogic.Interface;
using Assignment.DataAccess.Interface;
using Assignment.DTOs;
using Assignment.ResponseType;

namespace Assignment.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async ValueTask<ResponseBase> CreateUserAsync(CreateUserDto createUser)
        {
            try
            {
                return await _userRepository.CreateUser(createUser);

            }
            catch (Exception ex)
            {
                return new InternalServer
                (
                    ex: ex,
                    message: ex.Message
                );
            }

        }

        public async ValueTask<ResponseBase> GetAllAsync()
        {
            try
            {
                return await _userRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                return new InternalServer
                (
                    ex: ex,
                    message: ex.Message
                );
            }
        }

        public async ValueTask<ResponseBase> GetByIdAsync(string id)
        {
            try
            {
                return await _userRepository.GetByIdAsync(Guid.Parse(id));
            }
            catch (Exception ex)
            {
                return new InternalServer
                (
                    ex: ex,
                    message: ex.Message
                );
            }
        }

        public async ValueTask<ResponseBase> UpdateAsync(UpdateUserDto updateUser)
        {
            try
            {

                return await _userRepository.UpdateAsync(updateUser);
            }
            catch (Exception ex)
            {
                return new InternalServer(ex: ex, message: ex.Message);
            }
        }

        public async ValueTask<ResponseBase> DeleteAsync(string id)
        {
            try
            {
                return await _userRepository.DeleteAsync(Guid.Parse(id));
            }
            catch (Exception ex)
            {
                return new InternalServer(
                    ex: ex,
                    message: ex.Message);
            }
        }

        public async ValueTask<ResponseBase> LoginAsync(LoginDto loginDto)
        {
            try
            {
                return await _userRepository.LoginAsync(loginDto);
            }
            catch (Exception ex)
            {
                return new InternalServer(
                    ex: ex,
                    message: ex.Message);
            }
        }

        public async ValueTask<ResponseBase> SearchUsersAsync(SearchDto searchParams)
        {
            try
            {
                return await _userRepository.SearchUsersAsync(searchParams);
            }
            catch (Exception ex)
            {
                return new InternalServer(
                    ex: ex,
                    message: ex.Message);
            }
        }
    }
}
