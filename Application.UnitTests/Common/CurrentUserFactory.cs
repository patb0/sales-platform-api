using Moq;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class CurrentUserFactory
    {
        public static Mock<ICurrentUserService> MockCurrentUser()
        {
            var currentUserMock = new Mock<ICurrentUserService>();
            currentUserMock.Setup(m => m.UserRole).Returns("Admin");
            currentUserMock.Setup(m => m.IsAuthenticated).Returns(true);
            currentUserMock.Setup(m => m.UserName).Returns("Administrator");

            return currentUserMock;
        }
            
    }
}
