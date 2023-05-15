using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Products.Queries.ViewModel;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailById
{
    public class GetProductBasicDetailByIdQueryHandler : IRequestHandler<GetProductBasicDetailByIdQuery, ProductBasicDetailViewModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductBasicDetailByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductBasicDetailViewModel> Handle(GetProductBasicDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Include(i => i.Images)
                .Where(i => i.Id == request.ProductId
                && i.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if(product == null)
            {
                throw new NotFoundProductException();
            }

            var productVm = _mapper.Map<ProductBasicDetailViewModel>(product);

            return productVm;
        }
    }
}