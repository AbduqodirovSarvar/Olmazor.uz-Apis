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
using Infrastructure.Models;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistance.DefaultData;

namespace Infrastructure.Extentions
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IHashService, HashService>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            var dataSource = dataSourceBuilder.Build();

            /*services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
            });*/

            services.AddDbContext<IAppDbContext, AppDbContext>((serviceProvider, options) =>
            {

                options.UseNpgsql(dataSource,
                    options =>
                    {
                        options.MigrationsAssembly(typeof(AppDbContext).Assembly.GetName().Name);
                        options.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(30), errorCodesToAdd: null);
                        options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    })
                    .EnableSensitiveDataLogging();
            });

            /*services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));*/

            using var serviceProvider = services.BuildServiceProvider();
            var hashService = serviceProvider.GetRequiredService<IHashService>();
            DefaultUserData.Initialize(hashService);

            services.AddApplication();
            return services;
        }
    }
}
