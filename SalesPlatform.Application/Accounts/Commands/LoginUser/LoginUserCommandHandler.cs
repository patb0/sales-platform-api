﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using Microsoft.IdentityModel.Tokens;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Services;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IApplicationDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IAuthenticationSettings _authenticationSettings;
        private readonly IGenerateJwtToken _generateJwtToken;

        public LoginUserCommandHandler(IApplicationDbContext context,
            IPasswordHasher<User> passwordHasher,
            IAuthenticationSettings authenticationSettings,
            IGenerateJwtToken generateJwtToken)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _authenticationSettings = authenticationSettings;
            _generateJwtToken = generateJwtToken;
        }

        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Include("Account.Role")
                .Select(x => new User
                { 
                    Id = x.Id,
                    Account = x.Account,
                    UserName = x.UserName,
                    Created = x.Created,
                })
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Account.Login == request.Login);


            if (user == null)
            {
                throw new InvalidUserDataException();
            }


            //check password
            var checkPassword = _passwordHasher.VerifyHashedPassword(user, user.Account.PasswordHash, request.Password);

            if (checkPassword == PasswordVerificationResult.Failed)
            {
                throw new InvalidUserDataException();
            }

            var userToken = _generateJwtToken.Generate(user, _authenticationSettings);

            return userToken;
        }
    }
}
