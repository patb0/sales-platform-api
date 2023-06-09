﻿using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SalesPlatform.Application.Accounts.Commands.RegisterUser;
using SalesPlatform.Application.Common;
using SalesPlatform.Application.Common.Behaviours;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Services;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
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

            //add dependency for IPasswordHasher
            services.AddScoped<IPasswordHasher<Account>, PasswordHasher<Account>>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            //add dependecy for IAuthenticationSettings
            services.AddScoped<IAuthenticationSettings, AuthenticationSettings>();

            //add dependency for IGenerateJwtToken
            services.AddScoped<IGenerateJwtToken, JwtTokenService>();

            //add image dependency
            services.AddScoped<IImageUpload, ImageService>();
            services.AddScoped<IImageDelete, ImageService>();

            //add cloudinary settings from appsettings.json
            var cloudinarySettings = new CloudinarySettings();
            configuration.GetSection("CloudinarySeetings").Bind(cloudinarySettings);
            services.AddSingleton(cloudinarySettings);

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

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            return services;
        }
    }
}
