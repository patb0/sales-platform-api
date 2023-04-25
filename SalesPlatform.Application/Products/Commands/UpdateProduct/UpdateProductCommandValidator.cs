using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(a => a.Product.ProducerName)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(b => b.Product.Color)
                .MaximumLength(20);

            RuleFor(c => c.Product.Name)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(d => d.Product.Price)
                .NotEmpty();

            RuleFor(e => e.Product.Quantity)
                .InclusiveBetween(1, 999);

            RuleFor(f => f.Product.Description)
                .MaximumLength(1000)
                .NotEmpty();

            RuleFor(g => g.Product.VAT)
                .NotEmpty();
        }
    }
}
