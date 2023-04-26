using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Opinions.Commands.AddProductOpinion
{
    public class AddProductOpinionCommandValidator : AbstractValidator<AddProductOpinionCommand>
    {
        public AddProductOpinionCommandValidator()
        {
            RuleFor(a => a.Rating)
                .InclusiveBetween(1, 5)
                .NotEmpty();

            RuleFor(b => b.Comment)
                .MaximumLength(1000);

            RuleFor(c => c.ProductId)
                .NotEmpty();
        }
    }
}
