using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Exceptions
{
    public class WrongEmailException : Exception
    {
        public WrongEmailException(string email, Exception ex) : base($"Email {email} is invalid!", ex)
        {
            
        }
    }
}
