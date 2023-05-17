using MediatR;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Opinions.Commands.AddProductOpinion
{
    public class AddProductOpinionCommandHandler : IRequestHandler<AddProductOpinionCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public AddProductOpinionCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(AddProductOpinionCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == request.ProductId
                || p.StatusId == 1);

            if(product == null)
            {
                throw new NotFoundProductException();
            }

            var newOpinion = new Opinion
            {
                Rating = request.Rating,
                Comment = request.Comment,
                ProductId = request.ProductId,
                AddedBy = _currentUser.UserName,
            };

            _context.Opinions.Add(newOpinion);
            _context.SaveChanges();

            return newOpinion.Id;
        }
    }
}
