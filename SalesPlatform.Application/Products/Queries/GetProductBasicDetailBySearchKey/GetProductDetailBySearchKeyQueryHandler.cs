using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey
{
    public class GetProductDetailBySearchKeyQueryHandler
        : IRequestHandler<GetProductDetailBySearchKeyQuery, ProductDetailBySearchKeyDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductDetailBySearchKeyQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDetailBySearchKeyDto> Handle(GetProductDetailBySearchKeyQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products
                .Where(a => a.Name.Contains(request.SearchKey)
                || a.ProductDetail.ProducerName.Contains(request.SearchKey))
                .ToListAsync();

            if (products.Count() == 0)
            {
                throw new NotFoundProductException();
            }

            var productsVm = _mapper.Map<ICollection<ProductDetailBySearchKeyViewModel>>(products);

            return new ProductDetailBySearchKeyDto { Products = productsVm };
        }
    }
}
