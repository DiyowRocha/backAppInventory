using backAppInventory.Infrastructure.Context;
using backAppInventory.Infrastructure.Repositories.Interfaces;
using backAppInventory.Infrastructure.Repositories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace backAppInventory.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));

        services.AddScoped<IUnitRepository, UnitRepository>();

        return services;
    }
}