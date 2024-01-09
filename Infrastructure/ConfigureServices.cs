using Application.Interfaces;
using Application.Interfaces.Repository;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration, bool registerMassTransit = true)
    {

        //services.AddDbContext<SqlDbContext>(options =>
        //    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
        //        builder => builder.MigrationsAssembly(typeof(SqlDbContext).Assembly.FullName)));

        //DB Imitation
        services.AddScoped<ISqlApplicationDbContext, SqlDbContext>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}