using Domain.Interfaces.Commom;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureModule
    {
        public static void AddInfrastructureModule(this IServiceCollection services) 
        { 
            services.AddDependecyInjections();
        }


        public  static void AddDependecyInjections(this IServiceCollection services)
        {
            services.AddScoped<IHospedeRepository, HospedeRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
        }
    }
}
