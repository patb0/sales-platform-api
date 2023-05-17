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
                .NotNull()
                .NotEmpty()
                .InclusiveBetween(1, 5)
                .WithMessage("Rating is required and must be between 1 and 5.");

            RuleFor(b => b.Comment)
                .MaximumLength(1000)
                .WithMessage("Comment can have to 1000 chars!");

            RuleFor(c => c.ProductId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Product Id is required.");
        }
    }
}
