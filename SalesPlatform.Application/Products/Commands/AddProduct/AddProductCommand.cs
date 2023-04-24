using MediatR;
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
        public ProductCondition Condition { get; set; }
        public ProductCategory Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool VAT { get; set; }
        public string ProducerName { get; set; }
        public string Country { get; set; }
        public string Color { get; set; }
    }
}
