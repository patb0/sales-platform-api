using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Exceptions
{
    public class NotFoundProductException : Exception
    {
        public NotFoundProductException() : base($"Product/s not found!")
        {
            
        }
    }
}
