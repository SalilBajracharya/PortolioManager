using PortfolioManager.Api.Services.Auth;
using PortfolioManager.Api.Services.User;

namespace PortfolioManager.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
