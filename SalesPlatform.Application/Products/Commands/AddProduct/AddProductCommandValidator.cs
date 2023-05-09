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
            RuleFor(a => a.Product.ProducerName)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(b => b.Product.Color)
                .MaximumLength(20);

            RuleFor(c => c.Product.ProducerName)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(d => d.Product.ProducerName)
                .NotEmpty();

            RuleFor(e => e.Product.Quantity)
                .InclusiveBetween(1, 999);

            RuleFor(f => f.Product.Description)
                .MaximumLength(1000)
                .NotEmpty();

            RuleFor(g => g.Product.VAT)
                .NotEmpty();

            //todo
            //add range for images (max 5)
        }
    }
}
