using SalesPlatform.Application.Products.Queries.Common;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey
{
    public class ProductDetailBySearchKeyDto
    {
        public ICollection<ProductDetailBySearchKeyViewModel> Products { get; set; }
    }
}