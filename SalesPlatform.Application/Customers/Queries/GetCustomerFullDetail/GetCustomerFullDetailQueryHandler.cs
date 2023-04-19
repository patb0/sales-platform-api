using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Customers.Queries.GetCustomerFullDetail
{
    public class GetCustomerFullDetailQueryHandler : IRequestHandler<GetCustomerFullDetailQuery, CustomerFullDetailViewModel>
    {
        private readonly IApplicationDbContext _context;
        public GetCustomerFullDetailQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerFullDetailViewModel> Handle(GetCustomerFullDetailQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers
                .Include(c => c.Address)
                .Include(c => c.Contact)
                .Include(c => c.Products)
                .Where(c => c.Id == request.CustomerId)
                .FirstOrDefaultAsync(cancellationToken);

            var vm = new CustomerFullDetailViewModel
            {
                FirstName = customer.CustomerName.FirstName,
                LastName = customer.CustomerName.LastName,
                NIP = customer.NIP,
                Country = customer.Address.Country.ToString(),
                City = customer.Address.City,
                Street = customer.Address.Street,
                EmailAddress = customer.Contact.EmailAddress,
                PhoneNumber = customer.Contact.PhoneNumber,
            };

            return vm;
        }
    }
}
