using SalesPlatform.Application.Products.Queries.ViewModel;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey
{
    public class ProductDetailBySearchKeyDto
    {
        public ICollection<ProductDetailBySearchKeyViewModel> Products { get; set; }
    }
}