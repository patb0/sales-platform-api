using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Commands.AddProduct
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(a => a.ProducerName)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(b => b.Color)
                .MaximumLength(20);

            RuleFor(c => c.Name)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(d => d.Price)
                .NotEmpty();

            RuleFor(e => e.Quantity)
                .InclusiveBetween(1, 999);

            RuleFor(f => f.Description)
                .MaximumLength(1000)
                .NotEmpty();

            RuleFor(g => g.VAT)
                .NotEmpty();
        }
    }
}
