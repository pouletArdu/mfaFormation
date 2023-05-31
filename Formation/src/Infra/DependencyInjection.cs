using Application.Repositories;
using Infra.Persistence;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(configuration.GetSection("Sqlite").Value)
        );

        services.AddAutoMapper(assembly);

        services.AddScoped<ClientRepository, ClientRepositoryImp>();

        return services;
    }
}