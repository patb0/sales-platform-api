using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Products.Queries.GetProductFullDetailById;
using SalesPlatform.Application.Products.Queries.ViewModel;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductFullDetailById
{
    public class GetProductFullDetailByIdQueryHandler : IRequestHandler<GetProductFullDetailByIdQuery, ProductFullDetailViewModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetProductFullDetailByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductFullDetailViewModel> Handle(GetProductFullDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Include(p => p.ProductDetail)
                .Include(p => p.Images)
                .Where(i => i.Id == request.ProductId)
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
            {
                throw new NotFoundProductException();
            }

            var productVm = _mapper.Map<ProductFullDetailViewModel>(product);

            return productVm;
        }
    }
}
