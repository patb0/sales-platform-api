using FluentValidation;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.LoginUser
{
    public class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
    {
        public LoginUserCommandValidator()
        {
            RuleFor(x => x.Login)
                .MinimumLength(6)
                .MaximumLength(20)
                .NotEmpty();

            RuleFor(y => y.Password)
                .MinimumLength(6)
                .MaximumLength(20)
                .NotEmpty();
        }
    }
}
