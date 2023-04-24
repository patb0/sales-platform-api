using SalesPlatform.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.ViewModel
{
    public class ProductFullDetailViewModel
    {
        public int Id { get; set; }
        public string ProducerName { get; set; }
        public string Country { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Condition { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public bool VAT { get; set; }
        //public string Photos { get; set; }
    }
}
