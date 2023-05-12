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
            RuleFor(x => x.Contact.EmailAddress)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Contact.PhoneNumber)
                .NotEmpty()
                .MaximumLength(15);

            //validation for address
            RuleFor(x => x.Address.Country).NotEmpty();
            RuleFor(x => x.Address.City)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.Address.ZipCode)
                .NotEmpty()
                .MaximumLength(10);

            RuleFor(x => x.Address.City)
               .NotEmpty()
               .MaximumLength(20);

            RuleFor(x => x.Address.Street)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.Address.FlatNumber)
                .NotEmpty()
                .MaximumLength(10);

            //validation for account
            RuleFor(x => x.Account.Login)
                .MinimumLength(6)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(x => x.Account.Password)
                .MinimumLength(6)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(x => x.Account.PasswordConfirm).Equal(y => y.Account.Password);

            RuleFor(x => x.Account.Login)
                .Custom((value, context) =>
                {
                    var loginInUse = _context.Accounts.Any(y => y.Login == value);
                    if (loginInUse)
                    {
                        context.AddFailure("Login", "This login is already in use!");
                    }
                });

            //validation for user details
            RuleFor(x => x.UserData.FirstName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.UserData.LastName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.UserData.NIP)
                .MaximumLength(10);
        }
    }
}
