using MediatR;
using SalesPlatform.Application.Customers.Queries.GetCustomerDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQuery : IRequest<CustomerDetailViewModel>
    {
        public int CustomerId { get; set; }
    }
}
