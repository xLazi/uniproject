using CarServiceMy.BL.Interfaces;
using CarServiceMy.BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarServiceMy.BL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
        {
            // Register BL services here
            services.AddSingleton<ICustomerService, CustomerService>();
            return services;
        }
    }
}
