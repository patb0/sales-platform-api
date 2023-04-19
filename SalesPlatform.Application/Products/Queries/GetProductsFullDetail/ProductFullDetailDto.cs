using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesPlatform.Application.Products.Queries.Common;

namespace SalesPlatform.Application.Products.Queries.GetProductsFullDetail
{
    public class ProductFullDetailDto
    {
        public ICollection<ProductFullDetailViewModel> Products { get; set; }
    }
}
