using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Exceptions
{
    public class NotFoundOpinionException : Exception
    {
        public NotFoundOpinionException(int productId) : base($"Product: {productId} doesnt have any opinions!")
        {
            
        }
    }
}
