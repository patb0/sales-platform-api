using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey
{
    public class GetProductDetailBySearchKeyQueryValidator : AbstractValidator<GetProductDetailBySearchKeyQuery>
    {
        public GetProductDetailBySearchKeyQueryValidator()
        {
            RuleFor(a => a.SearchKey)
                .NotEmpty()
                .NotNull()
                .MaximumLength(15)
                .WithMessage("Search key is required and must be to 10 chars!");
        }
    }
}
