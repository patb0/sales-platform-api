using MediatR;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Queries.GetCurrentUserRole
{
    public class GetCurrentUserRoleQueryHandler : IRequestHandler<GetCurrentUserRoleQuery, string>
    {
        private readonly ICurrentUserService _currentUser;
        public GetCurrentUserRoleQueryHandler(ICurrentUserService currentUser)
        {
            _currentUser = currentUser;
        }
        public async Task<string> Handle(GetCurrentUserRoleQuery request, CancellationToken cancellationToken)
        {
            var currentUserRole = _currentUser.UserRole;

            return currentUserRole;
        }
    }
}
