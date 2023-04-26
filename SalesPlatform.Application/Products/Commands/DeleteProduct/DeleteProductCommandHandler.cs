using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IApplicationDbContext _context;
        public DeleteProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Include(i => i.ProductDetail)
                .Where(x => x.Id == request.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null || product.StatusId == 0) 
            {
                throw new NotFoundProductException();
            }

            _context.Products.Remove(product);

            _context.SaveChangesWithAuditable();

            return Unit.Value;
        }
    }
}
