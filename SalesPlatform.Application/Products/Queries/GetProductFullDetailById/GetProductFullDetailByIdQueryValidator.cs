using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductFullDetailById
{
    public class GetProductFullDetailByIdQueryValidator : AbstractValidator<GetProductFullDetailByIdQuery>
    {
        public GetProductFullDetailByIdQueryValidator()
        {
            RuleFor(a => a.ProductId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Product Id is required and must be greater than 0!");
        }
    }
}
