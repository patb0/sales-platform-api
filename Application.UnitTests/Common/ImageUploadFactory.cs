using Moq;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class ImageUploadFactory
    {
        public static Mock<IImageUpload> MockImageUpload()
        {
            var mockImageUpload = new Mock<IImageUpload>();

            return mockImageUpload;
        }
    }
}
