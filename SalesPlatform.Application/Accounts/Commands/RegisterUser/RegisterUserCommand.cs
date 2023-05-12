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
        public UserDto UserData { get; set; }
        public AddressDto Address { get; set; }
        public ContactDto Contact { get; set; }
        public AccountDto Account { get; set; }
    }
}
