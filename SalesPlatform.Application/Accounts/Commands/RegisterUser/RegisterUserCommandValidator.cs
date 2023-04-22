using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.RegisterUser
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public RegisterUserCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            //validation for contact
            RuleFor(x => x.ContactDto.EmailAddress)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.ContactDto.PhoneNumber)
                .NotEmpty()
                .MaximumLength(15);

            //validation for address
            RuleFor(x => x.AddressDto.Country).NotEmpty();
            RuleFor(x => x.AddressDto.City)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.AddressDto.ZipCode)
                .NotEmpty()
                .MaximumLength(10);

            RuleFor(x => x.AddressDto.City)
               .NotEmpty()
               .MaximumLength(20);

            RuleFor(x => x.AddressDto.Street)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.AddressDto.FlatNumber)
                .NotEmpty()
                .MaximumLength(10);

            //validation for account
            RuleFor(x => x.AccountDto.Login)
                .MinimumLength(6)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(x => x.AccountDto.Password)
                .MinimumLength(6)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(x => x.AccountDto.PasswordConfirm).Equal(y => y.AccountDto.Password);

            RuleFor(x => x.AccountDto.Login)
                .Custom((value, context) =>
                {
                    var loginInUse = _context.Accounts.Any(y => y.Login == value);
                    if (loginInUse)
                    {
                        context.AddFailure("Login", "This login is already in use!");
                    }
                });

            //validation for user details
            RuleFor(x => x.UserDto.FirstName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.UserDto.LastName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.UserDto.NIP)
                .MaximumLength(10);
        }
    }
}
