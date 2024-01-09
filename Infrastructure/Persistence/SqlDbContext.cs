using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Persistence;

public class SqlDbContext : ISqlApplicationDbContext
{
    public List<User> Users { get; set; }

    public Task<List<User>> GetAllUsers()
    {
        return Task.FromResult(Users);
    }
}