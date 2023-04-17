using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Entities
{
    public class Opinion
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } 

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
