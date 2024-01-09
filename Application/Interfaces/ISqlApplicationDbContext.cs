using Domain.Entities;

namespace Application.Interfaces;

public interface ISqlApplicationDbContext
{
    public Task<List<User>> GetAllUsers();
}