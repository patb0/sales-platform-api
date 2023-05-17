using Application.UnitTests.Common;
using FluentValidation.TestHelper;
using Microsoft.AspNetCore.Identity;
using SalesPlatform.Application.Accounts.Commands.LoginUser;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Services;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Accounts.Commands
{
    public class LoginUserCommandHandlerTests : CommandTestBase
    {
        private readonly LoginUserCommandHandler _handler;
        private readonly IAuthenticationSettings _authSettings;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IGenerateJwtToken _generateJwtToken;
        private readonly LoginUserCommandValidator _validator;

        public LoginUserCommandHandlerTests() : base()
        {
            _authSettings = AuthenticationSettingsFactory.MockAuthenticationSettings().Object;
            _passwordHasher = new PasswordHasher<User>();
            _generateJwtToken = new JwtTokenService();
            _validator = new LoginUserCommandValidator();

            _handler = new LoginUserCommandHandler(_context, _passwordHasher, _authSettings, _generateJwtToken);
        }

        [Theory]
        [InlineData("patryk", "password")]
        [InlineData("damian", "password")]
        public async Task LoginUserCommandHandler_GivenValidRequest_ShouldGenerateJwtToken(string login, string password)
        {
            // arrange
            var command = new LoginUserCommand() 
            { 
                Login = login, 
                Password = password 
            };

            // act
            var result = await _handler.Handle(command, CancellationToken.None);

            // assert
            Assert.IsType<string>(result);
        }

        [Theory]
        [InlineData("invalidlogin", "password")]
        [InlineData("wronglogin", "password")]
        public async Task LoginUserCommandHandler_GivenWrongLogin_ShouldThrowException(string login, string password)
        {
            // arrange
            var command = new LoginUserCommand()
            {
                Login = login,
                Password = password
            };

            // act
            var result = _handler.Handle(command, CancellationToken.None);

            // assert
            Assert.ThrowsAnyAsync<InvalidUserDataException>(() => result); 
        }

        [Theory]
        [InlineData("patryk", "wrongpass")]
        [InlineData("damian", "invalidpassword")]
        public async Task LoginUserCommandHandler_GivenWrongPassword_ShouldThrowException(string login, string password)
        {
            // arrange
            var command = new LoginUserCommand()
            {
                Login = login,
                Password = password
            };

            // act
            var result = _handler.Handle(command, CancellationToken.None);

            // assert
            Assert.ThrowsAnyAsync<InvalidUserDataException>(() => result);
        }

        [Theory]
        [InlineData(null, "12345")]
        [InlineData("1234", null)]
        [InlineData(null, null)]
        public void LoginUserCommandHandler_GivenInvalidRequest_ShouldHaveValidationError(string login, string password)
        {
            // arrange
            var command = new LoginUserCommand()
            {
                Login = login,
                Password = password
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveAnyValidationError();
        }

        [Theory]
        [InlineData("patryk", "password")]
        [InlineData("testlogin", "1234567")]
        [InlineData("logintotest", "09876543")]
        public void LoginUserCommandHandler_GivenValidRequest_ShouldNotHaveValidationError(string login, string password)
        {
            // arrange
            var command = new LoginUserCommand()
            {
                Login = login,
                Password = password
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
