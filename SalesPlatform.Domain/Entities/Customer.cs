using SalesPlatform.Domain.Common;
using SalesPlatform.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int Id { get; set; }
        public CustomerName CustomerName { get; set; }
        public string NIP { get; set; }

        //product 1:n
        public ICollection<Product> Products { get; set; }
        //contact 1:1
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        //address 1:1
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
