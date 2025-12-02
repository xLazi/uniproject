using CarServiceMy.DL.Interfaces;
using CarServiceMy.DL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarServiceMy.DL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            // Register DL services here
            services.AddSingleton<ICustomerRepository, CustomerStaticRepository>();
            return services;
        }
    }
}
