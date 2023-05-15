using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Exceptions
{
    public class CannotCreateProductException : Exception
    {
        public CannotCreateProductException(Exception exception) : base($"Cannon create product!\n" + exception)
        {
            
        }
    }
}
