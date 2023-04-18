using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductsFullDetail
{
    public class GetProductsFullDetailQueryHandler : IRequestHandler<GetProductsFullDetailQuery, ProductFullDetailDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsFullDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductFullDetailDto> Handle(GetProductsFullDetailQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.Include(p => p.ProductDetails).ToListAsync();

            var productsVm = _mapper.Map<ICollection<ProductFullDetailViewModel>>(products);
                
            return new ProductFullDetailDto { Products = productsVm };
        }
    }
}
