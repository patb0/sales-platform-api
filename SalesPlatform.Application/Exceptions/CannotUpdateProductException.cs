using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Exceptions
{
    public class CannotUpdateProductException : Exception
    {
        public CannotUpdateProductException(int id, Exception ex) : base("Cannot update product with id: {id}", ex)
        {
            
        }
    }
}
