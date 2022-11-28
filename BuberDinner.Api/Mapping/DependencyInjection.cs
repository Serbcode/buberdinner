using System.Reflection;
using Mapster;
using MapsterMapper;

namespace BuberDinner.Api.Mapping;

public static class DependencyInjection
{
    public static IServiceCollection AddMapping(this IServiceCollection services)
    {
        // take global config ref
        var config = TypeAdapterConfig.GlobalSettings;
        
        // load all (IRegister impl mappings) from the assembly
        config.Scan(Assembly.GetExecutingAssembly());
        
        // add global config to DI as singleton
        services.AddSingleton(config);

        // add mapper to DI (ServiceMapper is Mapper itself configured for DI)
        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }
}