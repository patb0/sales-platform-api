using SalesPlatform.Infrastructure;
using SalesPlatform.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SalesPlatform.Application.Accounts.Commands.LoginUser;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

//Add configuration for JWT authentication
//builder.Services.AddAuthentication(option =>
//{
//    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    //option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(o =>
//    {
//        o.RequireHttpsMetadata = false;
//        o.SaveToken = true;
//        o.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateIssuer = true,
//            ValidIssuer = builder.Configuration["Authentication: JwtIssuer"],
//            ValidateAudience = false,
//            ValidAudience = builder.Configuration["Authentication: JwtIssuer"],
//            ValidateIssuerSigningKey = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Authentication:JwtKey"])),
//            //ValidateIssuer = true,
//            //ValidateAudience = true,
//            //ValidateLifetime = false,
//            //ValidateIssuerSigningKey = true,
//        };
//    });

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add dependency injection
builder.Services.ApplicationRegister(builder.Configuration);
builder.Services.InfrastructureRegister(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
