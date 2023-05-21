using Application.UnitTests.Common;
using AutoMapper;
using FluentValidation.TestHelper;
using Microsoft.AspNetCore.Identity;
using SalesPlatform.Application.Accounts.Commands.Common;
using SalesPlatform.Application.Accounts.Commands.RegisterUser;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Mapping;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Accounts.Commands.RegisterUser
{
    public class RegisterUserCommandHandlerTests : CommandTestBase
    {
        private readonly RegisterUserCommandHandler _handler;
        private readonly IPasswordHasher<Account> _passwordHasher;
        private readonly IMapper _mapper;
        private readonly RegisterUserCommandValidator _validator;

        public RegisterUserCommandHandlerTests() : base()
        {
            _passwordHasher = new PasswordHasher<Account>();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
            _validator = new RegisterUserCommandValidator(_context);

            _handler = new RegisterUserCommandHandler(_context, _passwordHasher, _mapper);
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenValidRequest_ShouldCreateNewUser()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = "Patryk",
                    LastName = "Boguslawski",
                    NIP = "0123456789"
                },
                Account = new AccountDto()
                {
                    Login = "patrol",
                    Password = "password",
                    PasswordConfirm = "password",
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = "12-332",
                    City = "TestCity",
                    Street = "TestStreet",
                    FlatNumber = "12"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogus@mail.com",
                    PhoneNumber = "123456789",
                },
            };

            // act
            var result = await _handler.Handle(command, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenInvalidRequest_ShouldHaveValidationError()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = string.Empty,
                    LastName = string.Empty,
                    NIP = null
                },
                Account = new AccountDto()
                {
                    Login = string.Empty,
                    Password = string.Empty,
                    PasswordConfirm = null,
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = string.Empty,
                    City = string.Empty,
                    Street = string.Empty,
                    FlatNumber = string.Empty
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "aasda",
                    PhoneNumber = null,
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveAnyValidationError();
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenInvalidUserData_ShouldHaveValidationErrorForUserData()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = null,
                    LastName = string.Empty,
                    NIP = string.Empty
                },
                Account = new AccountDto()
                {
                    Login = "patrol",
                    Password = "password",
                    PasswordConfirm = "password",
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = "12-332",
                    City = "TestCity",
                    Street = "TestStreet",
                    FlatNumber = "12"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogus@mail.com",
                    PhoneNumber = "123456789",
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveValidationErrorFor(x => x.UserData.FirstName);
            result.ShouldHaveValidationErrorFor(x => x.UserData.LastName);
            result.ShouldHaveValidationErrorFor(x => x.UserData.NIP);
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenInvalidAccount_ShouldHaveValidationErrorForAccount()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = "Patryk",
                    LastName = "Boguslawski",
                    NIP = "0123456789"
                },
                Account = new AccountDto()
                {
                    Login = "",
                    Password = string.Empty,
                    PasswordConfirm = null,
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = "12-332",
                    City = "TestCity",
                    Street = "TestStreet",
                    FlatNumber = "12"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogus@mail.com",
                    PhoneNumber = "123456789",
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveValidationErrorFor(x => x.Account.Login);
            result.ShouldHaveValidationErrorFor(x => x.Account.Password);
            result.ShouldHaveValidationErrorFor(x => x.Account.PasswordConfirm);
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenInvalidAddress_ShouldHaveValidationErrorForAddress()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = "Patryk",
                    LastName = "Boguslawski",
                    NIP = "0123456789"
                },
                Account = new AccountDto()
                {
                    Login = "patrol",
                    Password = "password",
                    PasswordConfirm = "password",
                },
                Address = new AddressDto()
                {
                    Country = (SalesPlatform.Domain.Enums.Country)100000,
                    ZipCode = "",
                    City = null,
                    Street = string.Empty,
                    FlatNumber = "testtesttesttesttesttest"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogus@mail.com",
                    PhoneNumber = "123456789",
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveValidationErrorFor(x => x.Address.Country);
            result.ShouldHaveValidationErrorFor(x => x.Address.ZipCode);
            result.ShouldHaveValidationErrorFor(x => x.Address.City);
            result.ShouldHaveValidationErrorFor(x => x.Address.Street);
            result.ShouldHaveValidationErrorFor(x => x.Address.FlatNumber);
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenInvalidContact_ShouldHaveErrorValidationForContact()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = "Patryk",
                    LastName = "Boguslawski",
                    NIP = "0123456789"
                },
                Account = new AccountDto()
                {
                    Login = "patrol",
                    Password = "password",
                    PasswordConfirm = "password",
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = "12-332",
                    City = "TestCity",
                    Street = "TestStreet",
                    FlatNumber = "12"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogusmailcom",
                    PhoneNumber = "12345678900001203994827371",
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveValidationErrorFor(x => x.Contact.EmailAddress);
            result.ShouldHaveValidationErrorFor(x => x.Contact.PhoneNumber);
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenExistLogin_ShouldHaveValidationErrorForLogin()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = "Patryk",
                    LastName = "Boguslawski",
                    NIP = "0123456789"
                },
                Account = new AccountDto()
                {
                    Login = "patryk",
                    Password = "password",
                    PasswordConfirm = "password",
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = "12-332",
                    City = "TestCity",
                    Street = "TestStreet",
                    FlatNumber = "12"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogus@mail.com",
                    PhoneNumber = "123456789",
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveValidationErrorFor(x => x.Account.Login)
                .WithErrorMessage("Login is already in use!");
        }

        [Fact]
        public async Task RegisterUserCommandHandler_GivenDifferentPasswords_ShouldHaveValidationErrorForConfirmPassword()
        {
            // arrange
            var command = new RegisterUserCommand()
            {
                UserData = new UserDto()
                {
                    FirstName = "Patryk",
                    LastName = "Boguslawski",
                    NIP = "0123456789"
                },
                Account = new AccountDto()
                {
                    Login = "patryk",
                    Password = "password",
                    PasswordConfirm = "diffrentpassword",
                },
                Address = new AddressDto()
                {
                    Country = SalesPlatform.Domain.Enums.Country.Albania,
                    ZipCode = "12-332",
                    City = "TestCity",
                    Street = "TestStreet",
                    FlatNumber = "12"
                },
                Contact = new ContactDto()
                {
                    EmailAddress = "patrykbogus@mail.com",
                    PhoneNumber = "123456789",
                },
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveValidationErrorFor(x => x.Account.PasswordConfirm)
                .WithErrorMessage("Confirm password must be equal to password!");
        }
    }
}
