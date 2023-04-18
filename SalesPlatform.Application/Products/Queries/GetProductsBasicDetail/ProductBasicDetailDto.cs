using SalesPlatform.Application.Products.Queries.GetProductsBasicDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetail
{
    public class ProductBasicDetailDto
    {
        public ICollection<ProductBasicDetailViewModel> Products { get; set; }
    }
}
