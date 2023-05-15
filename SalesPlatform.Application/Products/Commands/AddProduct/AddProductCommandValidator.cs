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
            RuleFor(e => e.Product.Condition)
                .IsInEnum()
                .WithMessage("Value is doesnt exist in Condition!");

            RuleFor(e => e.Product.Category)
                .IsInEnum()
                .WithMessage("Value is doesnt exist in Category!");

            RuleFor(a => a.Product.Name)
                .MaximumLength(20)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name must be not null/empty and must have to 20 characters!");

            RuleFor(b => b.Product.Price)
                .InclusiveBetween(1, 999999)
                .NotEmpty()
                .NotNull()
                .WithMessage("Price cannot be not/null and must be between 1-999999!");

            RuleFor(c => c.Product.Quantity)
                .InclusiveBetween(1, 999)
                .NotEmpty()
                .NotNull()
                .WithMessage("Quantity cannot be null/empty and must be between 1-999!");

            RuleFor(d => d.Product.Description)
                .MaximumLength(1000)
                .NotEmpty()
                .NotNull()
                .WithMessage("Description cannot be null/empty and must have to 1000 characters!");

            RuleFor(e => e.Product.VAT)
                .NotEmpty()
                .NotNull()
                .WithMessage("VAT cannot be null/empty!");

            RuleFor(f => f.Images)
                .Must(f => f.Count <= 5)
                .WithMessage("Max 5 images allowed");

            RuleFor(g => g.Product.ProducerName)
                .MaximumLength(20)
                .NotEmpty()
                .NotNull()
                .WithMessage("Producer name must be not null/empty and must have to 20 characters!");

            RuleFor(h => h.Product.Color)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20)
                .WithMessage("Color cannot be null/empty and must have to 20 characters!");
        }
    }
}
