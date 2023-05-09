using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    internal interface IImageUpload
    {
        Task<ImageUploadResult> UploadImageAsync(IFormFile file);
    }
}
