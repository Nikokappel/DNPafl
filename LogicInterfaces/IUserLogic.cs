namespace Application.LogicInterfaces;
using Domain;
using Domain.DTOs;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDto userToCreate);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);

}