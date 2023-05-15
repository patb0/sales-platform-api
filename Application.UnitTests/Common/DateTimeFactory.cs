using Moq;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class DateTimeFactory
    {
        public static Mock<IDateTime> MockDateTime()
        {
            var mockDateTime = new Mock<IDateTime>();
            mockDateTime.Setup(m => m.Now).Returns(DateTime.Now);

            return mockDateTime;
        }
    }
}
