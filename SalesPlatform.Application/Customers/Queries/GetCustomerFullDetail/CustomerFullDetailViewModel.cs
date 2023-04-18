using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Customers.Queries.GetCustomerFullDetail
{
    public class CustomerFullDetailViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIP { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
