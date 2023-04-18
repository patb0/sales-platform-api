using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductsFullDetail
{
    public class ProductFullDetailDto
    {
        public ICollection<ProductFullDetailViewModel> Products { get; set; }
    }
}
