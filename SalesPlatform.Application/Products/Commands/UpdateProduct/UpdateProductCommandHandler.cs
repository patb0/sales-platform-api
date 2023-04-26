using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;
        public UpdateProductCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var productToUpdate = await _context.Products
                .Where(x => x.Id == request.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if(productToUpdate == null)
            {
                throw new NotFoundProductException();
            }
            else if(productToUpdate.UserId !=  _currentUser.UserId) //check if user is product owner
            {
                throw new UnauthorizedProductAccessException(_currentUser.UserId);
            }

            try
            {
                productToUpdate.ProductDetail.ProducerName = request.Product.ProducerName;
                productToUpdate.ProductDetail.Country = request.Product.Country;
                productToUpdate.ProductDetail.Color = request.Product.Color;
                productToUpdate.Name = request.Product.Name;
                productToUpdate.Price = request.Product.Price;
                productToUpdate.Description = request.Product.Description;
                productToUpdate.VAT = request.Product.VAT;

                _context.Products.Update(productToUpdate);
                _context.SaveChangesWithAuditable();
            }
            catch (Exception ex)
            {
                throw new CannotUpdateProductException(request.Id, ex);
            }

            return Unit.Value;
        }
    }
}
