using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Opinions.Queries
{
    public class OpinionDto
    {
        public decimal AverageRating { get; set; }
        public ICollection<OpinionViewModel> Opinions { get; set; }
    }
}
