namespace Application.DaoInterfaces;
using Domain;
using Domain.DTOs;

public interface IUserDao
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByUsernameAsync(string userName);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);


    Task<User?> GetByIdAsync(int dtoOwnerId);
}