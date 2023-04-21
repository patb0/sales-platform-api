using FluentValidation;
using SalesPlatform.Application.Accounts.Commands.Common;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.Validators
{
    public class AccountDtoValidator : AbstractValidator<AccountDto>
    {
        private readonly IApplicationDbContext _context;
        public AccountDtoValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(x => x.Login)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.PasswordConfirm).Equal(y => y.Password);

            RuleFor(x => x.Login)
                .Custom((value, context) =>
                {
                    var loginInUse = _context.Accounts.Any(y => y.Login == value);
                    if(loginInUse)
                    {
                        context.AddFailure("Login", "This login is already in use!");
                    }
                });
        }
    }
}
