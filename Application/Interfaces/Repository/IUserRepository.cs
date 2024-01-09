using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IUserRepository
{
    public Task<List<User>> GetAllUsers();
}