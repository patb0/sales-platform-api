using MediatR;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Queries.GetCurrentUserDetail
{
    public class GetCurrentUserDetailQueryHandler : IRequestHandler<GetCurrentUserDetailQuery, CurrentUserDetailVm>
    {
        private readonly ICurrentUserService _currentUser;
        public GetCurrentUserDetailQueryHandler(ICurrentUserService currentUser)
        {
            _currentUser = currentUser;
        }
        public async Task<CurrentUserDetailVm> Handle(GetCurrentUserDetailQuery request, CancellationToken cancellationToken)
        {
            var isAuthenticated = _currentUser.IsAuthenticated;
            var userId = _currentUser.UserId;
            var userRole = _currentUser.UserRole;
            var userName = _currentUser.UserName;

            var userDetail = new CurrentUserDetailVm
            {
                IsAuthenticated = isAuthenticated,
                UserId = userId,
                UserRole = userRole,
                UserName = userName
            };

            return userDetail;
        }
    }
}
