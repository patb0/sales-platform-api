using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Exceptions
{
    public class InvalidUserDataException : Exception
    {
        public InvalidUserDataException() : base("Invalid user login or password!")
        {
            
        }
    }
}
