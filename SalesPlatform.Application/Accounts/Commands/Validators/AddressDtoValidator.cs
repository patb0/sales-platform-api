using FluentValidation;
using SalesPlatform.Application.Accounts.Commands.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.Validators
{
    public class AddressDtoValidator : AbstractValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.City)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.ZipCode)
                .NotEmpty()
                .MaximumLength(10);

            RuleFor(x => x.City)
               .NotEmpty()
               .MaximumLength(20);

            RuleFor(x => x.Street)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.FlatNumber)
                .NotEmpty()
                .MaximumLength(10);
                
        }
    }
}
