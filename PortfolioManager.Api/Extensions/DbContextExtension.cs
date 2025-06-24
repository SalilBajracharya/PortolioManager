using Microsoft.EntityFrameworkCore;
using PortfolioManager.Api.Persistence;

namespace PortfolioManager.Api.Extensions
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
