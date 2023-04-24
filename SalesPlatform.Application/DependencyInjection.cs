using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
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

            //added IPasswordHasher
            services.AddScoped<IPasswordHasher<Account>, PasswordHasher<Account>>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();


            //authentication variables from appsettings.json
            var authenticationSettings = new AuthenticationSettings();

            configuration.GetSection("Authentication").Bind(authenticationSettings);
            services.AddSingleton(authenticationSettings);


            //add configuration for JWT authentication
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                //option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false;
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = authenticationSettings.JwtIssuer,
                    ValidateAudience = false,
                    ValidAudience = authenticationSettings.JwtIssuer,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey)),
                    //ValidateIssuer = true,
                    //ValidateAudience = true,
                    //ValidateLifetime = false,
                    //ValidateIssuerSigningKey = true,
                };
            });

            return services;
        }
    }
}
