using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Products.Queries.ViewModel;
using SalesPlatform.Application.Products.Queries.GetProductsBasicDetail;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetail
{
    public class GetProductsBasicDetailQueryHandler : IRequestHandler<GetProductsBasicDetailQuery, ProductBasicDetailDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsBasicDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductBasicDetailDto> Handle(GetProductsBasicDetailQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products
                .Include(i => i.Images)
                .Where(x => x.StatusId == 1)
                .ToListAsync();

            if(products.Count() == 0)
            {
                throw new NotFoundProductException();
            }
                
            var productsVm = _mapper.Map<ICollection<ProductBasicDetailViewModel>>(products);

            return new ProductBasicDetailDto { Products = productsVm };
        }
    }
}
