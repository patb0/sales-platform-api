using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesPlatform.Application.Accounts.Commands.LoginUser;
using SalesPlatform.Application.Accounts.Commands.RegisterUser;
using SalesPlatform.Application.Common.Behaviours;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ApplicationRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //fluent validation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddScoped<IPasswordHasher<Account>, PasswordHasher<Account>>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            //authentication
            var authenticationSettings = new AuthenticationSettings();

            configuration.GetSection("Authentication").Bind(authenticationSettings);
            services.AddSingleton(authenticationSettings);

            return services;
        }
    }
}
