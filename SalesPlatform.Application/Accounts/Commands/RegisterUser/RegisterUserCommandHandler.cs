using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.RegisterUser
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IPasswordHasher<Account> _passwordHasher;
        private readonly IMapper _mapper;
        public RegisterUserCommandHandler(IApplicationDbContext context, IPasswordHasher<Account> passwordHasher,
            IMapper mapper)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }
        public async Task<int> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            //add user address
            var newAddress = _mapper.Map<Address>(request.AddressDto);

            //add user contact
            var newContact = _mapper.Map<Contact>(request.ContactDto);

            //user account (login + password)
            var newAccount = _mapper.Map<Account>(request.AccountDto);

            var hashedPassword = _passwordHasher.HashPassword(newAccount, request.AccountDto.Password);
            newAccount.PasswordHash = hashedPassword;
            newAccount.RoleId = 2;

            //add up enties to db
            _context.AddRange(new List<object>
            {
                newAddress, newContact, newAccount,
            });

            _context.SaveChanges();

            //user with simple data and all foreign keys
            var newUser = _mapper.Map<User>(request.UserDto);
            newUser.AddressId = newAddress.Id;
            newUser.ContactId = newContact.Id;
            newUser.AccountId = newAccount.Id;

            _context.Users.Add(newUser);
            _context.SaveChangesWithAuditable();

            return newUser.Id;
        }
    }
}
