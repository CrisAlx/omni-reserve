using Microsoft.Extensions.DependencyInjection;

namespace OmniReserve.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Aquí agregaremos servicios de la capa Application próximamente (como MediatR, Validaciones, etc.)
        return services;
    }
}