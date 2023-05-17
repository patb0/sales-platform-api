using Microsoft.AspNetCore.Http;
using Moq;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public class GenerateJwtTokenFactory
    {
        public static Mock<IGenerateJwtToken> MockGenerateJwtToken()
        {
            var mockGenerateJwtToken = new Mock<IGenerateJwtToken>();
            
            return mockGenerateJwtToken;
        }
    }
}
