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
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.Contact.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .MaximumLength(15);

            //validation for address
            RuleFor(x => x.Address.Country)
                .NotEmpty()
                .NotNull()
                .IsInEnum();

            RuleFor(x => x.Address.City)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20);

            RuleFor(x => x.Address.ZipCode)
                .NotEmpty()
                .NotNull()
                .MaximumLength(10);

            RuleFor(x => x.Address.City)
               .NotEmpty()
               .NotNull()
               .MaximumLength(20);

            RuleFor(x => x.Address.Street)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20);

            RuleFor(x => x.Address.FlatNumber)
                .NotEmpty()
                .NotNull()
                .MaximumLength(10);

            //validation for account
            //RuleFor(x => x.Account.Login)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(6)
            //    .MaximumLength(20);

            RuleFor(x => x.Account.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(20)
                .WithMessage("Password is reauired and must be between 6 and 20 characters!");

            RuleFor(x => x.Account.PasswordConfirm)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(20)
                .WithMessage("Confirm password is reauired and must be between 6 and 20 characters!")
                .Equal(y => y.Account.Password)
                .WithMessage("Confirm password must be equal to password!");

            RuleFor(x => x.Account.Login)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(20)
                .Custom((value, context) =>
                {
                    var loginInUse = _context.Accounts.Any(y => y.Login == value);
                    if (loginInUse)
                    {
                        context.AddFailure("Login is already in use!");
                    }
                });

            //validation for user details
            RuleFor(x => x.UserData.FirstName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.UserData.LastName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.UserData.NIP)
                .NotEmpty()
                .Length(10);
        }
    }
}
