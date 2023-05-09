﻿using SalesPlatform.Domain.Common;
using SalesPlatform.Domain.Enums;
using SalesPlatform.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public ProductDetail ProductDetail { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool VAT { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Opinion> Opinions { get; set; }
        public ICollection<Image>? Images { get; set; }
    }
}