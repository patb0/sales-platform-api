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
    public class Contact
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }


        public User User { get; set; }
    }
}
