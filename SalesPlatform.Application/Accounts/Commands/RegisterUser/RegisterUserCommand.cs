using MediatR;
using SalesPlatform.Application.Accounts.Commands.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Commands.RegisterUser
{
    public class RegisterUserCommand : IRequest<int>
    {
        public UserDto UserDto { get; set; }
        public AddressDto AddressDto { get; set; }
        public ContactDto ContactDto { get; set; }
        public AccountDto AccountDto { get; set; }
    }
}
