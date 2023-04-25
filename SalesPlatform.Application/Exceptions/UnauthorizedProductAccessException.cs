using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Exceptions
{
    public class UnauthorizedProductAccessException : Exception
    {
        public UnauthorizedProductAccessException(int userId) : base($"User: {userId} is not owner this product!")
        {
            
        }
    }
}
