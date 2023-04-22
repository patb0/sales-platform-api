using Microsoft.IdentityModel.Tokens;
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
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.UserName.FirstName} {user.UserName.LastName}"),
                new Claim(ClaimTypes.Role, user.Account.RoleId.ToString()),
            };

            //private key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey));
            //credentials
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //expires
            var expires = DateTime.Now.AddDays(Convert.ToDouble(authenticationSettings.JwtExpireDays));

            var token = new JwtSecurityToken(authenticationSettings.JwtIssuer,
                authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }
    }
}
