using SalesPlatform.Domain.Common;
using SalesPlatform.Domain.Enums;
using SalesPlatform.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public int Id { get; set; }
        public ProductCondition Condition { get; set; }
        public ProductCategory Category { get; set; }
        public ProductDetail ProductDetails { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool VAT { get; set; }
        //to do:
        //-photos (main, gallery)


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Opinion> Opinions { get; set; }
    }
}