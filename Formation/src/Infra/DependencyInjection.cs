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
        var ass = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(ass);
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite(configuration.GetConnectionString("WebApiDatabase"))); ;
        services.AddScoped<ClientRepository, ClientRepositoryImp>();
        services.AddScoped<BookRepository, BookRepositoryImp>();
        services.AddScoped<AuthorRepository, AuthorRepositoryImp>();
        return services;
    }
}
