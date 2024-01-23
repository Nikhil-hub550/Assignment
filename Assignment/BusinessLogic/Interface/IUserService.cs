using Assignment.DTOs;
using Assignment.ResponseType;

namespace Assignment.BusinessLogic.Interface
{
    public interface IUserService
    {
        ValueTask<ResponseBase> CreateUserAsync(CreateUserDto createUser);
        ValueTask<ResponseBase> GetAllAsync();
        ValueTask<ResponseBase> GetByIdAsync(string id);
        ValueTask<ResponseBase> UpdateAsync(UpdateUserDto updateUser);
        ValueTask<ResponseBase> DeleteAsync(string id);
        ValueTask<ResponseBase> LoginAsync(LoginDto loginDto);
        ValueTask<ResponseBase> SearchUsersAsync(SearchDto searchParams);
    }
}
