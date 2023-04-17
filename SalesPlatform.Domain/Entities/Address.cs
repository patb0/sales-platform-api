﻿using SalesPlatform.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public string City { get; set; } 
        public string ZipCode { get; set; } 
        public string Street { get; set; } 
        public string FlatNumber { get; set; } 


        public Customer Customer { get; set; }
    }
}