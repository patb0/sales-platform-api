﻿using Microsoft.IdentityModel.Tokens;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.LoginUser
{
    public static class GenerateUserJwt
    {        
        public static string CreateToken(User user, AuthenticationSettings authenticationSettings)
        {
            var claims = new List<Claim>()
            {
                //new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                //new Claim(ClaimTypes.Name, $"{user.UserName.FirstName} {user.UserName.LastName}"),
                //new Claim(ClaimTypes.Role, user.Account.Role.Name),
                new Claim("id", user.Id.ToString()),
                new Claim("name", $"{user.UserName.FirstName} {user.UserName.LastName}"),
                new Claim("role", user.Account.Role.Name),
                new Claim("registration", user.Created.ToString("yyyy-MM-dd")),
            };

            //private key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey));
            //credentials
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //expires
            var expires = DateTime.Now.AddDays(Convert.ToDouble(authenticationSettings.JwtExpireDays));

            var token = new JwtSecurityToken(
                issuer : authenticationSettings.JwtIssuer,
                audience: authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            tokenHandler.OutboundClaimTypeMap.Clear();
            tokenHandler.InboundClaimTypeMap.Clear();

            return tokenHandler.WriteToken(token);
        }
    }
}
