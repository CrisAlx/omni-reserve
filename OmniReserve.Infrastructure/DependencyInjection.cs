using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OmniReserve.Infrastructure.Persistence;
using OmniReserve.Application.Common.Interfaces; 
using OmniReserve.Infrastructure.Security;      

namespace OmniReserve.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPasswordHasher, BCryptPasswordHasher>();

            return services;
        }
    }
}