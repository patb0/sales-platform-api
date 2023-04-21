using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Exceptions
{
    public class UserExistException : Exception
    {
        public UserExistException(string login) : base($"{login} is already in use!")
        {
            
        }
    }
}
