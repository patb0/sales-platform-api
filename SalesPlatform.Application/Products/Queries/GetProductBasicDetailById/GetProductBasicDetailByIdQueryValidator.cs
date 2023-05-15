using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailById
{
    public class GetProductBasicDetailByIdQueryValidator : AbstractValidator<GetProductBasicDetailByIdQuery>
    {
        public GetProductBasicDetailByIdQueryValidator()
        {
            RuleFor(x => x.ProductId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Product Id is required and must be greater than 0!");
        }
    }
}
