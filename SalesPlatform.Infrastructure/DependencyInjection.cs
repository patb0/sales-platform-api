using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Infrastructure.Persistence;
using SalesPlatform.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructureRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SalesPlatformConnection")));

            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            return services;
        }
    }
}
