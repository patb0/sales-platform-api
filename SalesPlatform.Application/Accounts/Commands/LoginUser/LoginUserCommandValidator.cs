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
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(20)
                .WithMessage("Login is required and can have between 6-20 chars!");

            RuleFor(y => y.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(20)
                .WithMessage("Password is required and can have between 6-20 chars!");
        }
    }
}
