using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    public interface IImageDelete
    {
        Task<DeletionResult> DeleteImageAsync(string publicId);
    }
}
