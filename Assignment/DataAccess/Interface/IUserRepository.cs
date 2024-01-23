using Assignment.DTOs;
using Assignment.ResponseType;

namespace Assignment.DataAccess.Interface
{
    public interface IUserRepository
    {
        ValueTask<ResponseBase> CreateUser(CreateUserDto createUser);
        ValueTask<ResponseBase> GetAllAsync();
        ValueTask<ResponseBase> GetByIdAsync(Guid id);
        ValueTask<ResponseBase> UpdateAsync(UpdateUserDto updateUser);
        ValueTask<ResponseBase> DeleteAsync(Guid id);
        ValueTask<ResponseBase> LoginAsync(LoginDto loginDto);
        ValueTask<ResponseBase> SearchUsersAsync(SearchDto searchParams);
    }
}
