using Moq;
using SalesPlatform.Application.Accounts.Commands.LoginUser;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class AuthenticationSettingsFactory
    {
        public static Mock<IAuthenticationSettings> MockAuthenticationSettings()
        {
            var authenticationSettingsMock = new Mock<IAuthenticationSettings>();
            authenticationSettingsMock.Setup(m => m.JwtKey).Returns("kdHmIQWQ1YU9IOMt8o0LfIoRFbZ2XI8ONXEXqwOHUpJ");
            authenticationSettingsMock.Setup(m => m.JwtExpireDays).Returns(15);
            authenticationSettingsMock.Setup(m => m.JwtIssuer).Returns("http://salesplatform.com");

            return authenticationSettingsMock;
        }
    }
}
