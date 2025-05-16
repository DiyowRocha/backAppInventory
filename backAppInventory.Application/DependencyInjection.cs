using backAppInventory.Application.Services.Interfaces;
using backAppInventory.Application.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace backAppInventory.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IMapperService, MapperService>();

        return services;
    }
}