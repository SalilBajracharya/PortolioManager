using Microsoft.OpenApi.Models;

namespace PortfolioManager.Api.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Portfolio Manager Api",
                    Version = "v1",
                    Description = "API for managing job portfolio"
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: 'Bearer {token}'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });


                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                         new OpenApiSecurityScheme{
                             Reference = new OpenApiReference{
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                             }
                          }, Array.Empty<string>()
                    }
                });
            });

            return services;
        }
    }
}
