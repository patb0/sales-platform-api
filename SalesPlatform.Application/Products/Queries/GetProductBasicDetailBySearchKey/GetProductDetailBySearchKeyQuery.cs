using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey
{
    public class GetProductDetailBySearchKeyQuery : IRequest<ProductDetailBySearchKeyDto>
    {
        public string SearchKey { get; set; }
    }
}
