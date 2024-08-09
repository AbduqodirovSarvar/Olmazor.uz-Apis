using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;
using Infrastructure.Persistance.EntityFramework;
using Infrastructure.Services;

namespace Infrastructure.Extentions
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IHashService, HashService>();
            services.AddApplication();
            return services;
        }
    }
}
