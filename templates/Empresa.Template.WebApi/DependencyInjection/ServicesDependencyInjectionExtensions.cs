namespace Empresa.Template.WebApi;

public static class ServicesDependencyInjectionExtensions
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        // Add your services here

        return services;
    }

    public static IServiceCollection AddServicesWithParam(this IServiceCollection services, string param)
        => services;
}