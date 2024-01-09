using System.Runtime.CompilerServices;
using Application.Interfaces;
using Application.Interfaces.Repository;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ISqlApplicationDbContext _context;

    public UserRepository(ISqlApplicationDbContext context)
    {
        _context = context;
    }

    public Task<List<User>> GetAllUsers()
    {
        return _context.GetAllUsers();
    }
}