using MediatR;
using Microsoft.AspNetCore.Http;
using SalesPlatform.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Commands.AddProduct
{
    public class AddProductCommand : IRequest<int>
    {
        public AddProductDto Product { get; set; }
        public ICollection<IFormFile> Images { get; set; }
    }
}
