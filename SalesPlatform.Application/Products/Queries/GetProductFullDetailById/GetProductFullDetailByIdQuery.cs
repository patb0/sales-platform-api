using MediatR;
using SalesPlatform.Application.Products.Queries.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductFullDetailById
{
    public class GetProductFullDetailByIdQuery : IRequest<ProductFullDetailViewModel>
    {
        public int ProductId { get; set; }
    }
}
