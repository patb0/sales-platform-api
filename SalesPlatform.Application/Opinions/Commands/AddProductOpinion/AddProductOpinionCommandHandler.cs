using MediatR;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
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
            var productId = request.ProductId;
            var rating = request.Rating;
            var comment = request.Comment;
            var addedBy = _currentUser.UserName;

            var newOpinion = new Opinion
            {
                Rating = rating,
                Comment = comment,
                ProductId = productId,
                AddedBy = addedBy,
            };

            _context.Opinions.Add(newOpinion);
            _context.SaveChanges();

            return newOpinion.Id;
        }
    }
}
