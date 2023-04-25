using MediatR;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Queries.GetCurrentUserId
{
    public class GetCurrentUserIdQueryHandler : IRequestHandler<GetCurrentUserIdQuery, int>
    {
        private readonly ICurrentUserService _currentUser;
        public GetCurrentUserIdQueryHandler(ICurrentUserService currentUser)
        {
            _currentUser = currentUser;
        }
        public async Task<int> Handle(GetCurrentUserIdQuery request, CancellationToken cancellationToken)
        {
            int userId = _currentUser.UserId;

            return userId;
        }
    }
}
