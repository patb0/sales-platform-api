using MediatR;
using SalesPlatform.Application.Customers.Queries.GetCustomerFullDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Customers.Queries.GetCustomerFullDetail
{
    public class GetCustomerFullDetailQuery : IRequest<CustomerFullDetailViewModel>
    {
        public int CustomerId { get; set; }
    }
}
