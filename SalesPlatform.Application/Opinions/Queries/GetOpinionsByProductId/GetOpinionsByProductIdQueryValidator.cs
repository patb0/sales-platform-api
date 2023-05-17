using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Opinions.Queries.GetOpinionsByProductId
{
    public class GetOpinionsByProductIdQueryValidator : AbstractValidator<GetOpinionsByProductIdQuery>
    {
        public GetOpinionsByProductIdQueryValidator()
        {
            RuleFor(a => a.ProductId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Product id is required and must be greater than 0!");
        }
    }
}
