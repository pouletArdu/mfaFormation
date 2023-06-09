﻿using Infra.Repositories;
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
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite(configuration.GetSection("Sqlite").Value));
        services.AddAutoMapper(ass);
        services.AddScoped<ClientRepository, ClientRepositoryImp>();
        return services;
    }
}
