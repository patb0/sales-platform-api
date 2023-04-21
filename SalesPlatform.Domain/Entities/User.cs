using SalesPlatform.Domain.Common;
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
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public PersonName UserName { get; set; }
        public string NIP { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
