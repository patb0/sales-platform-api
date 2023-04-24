using MediatR;
using SalesPlatform.Application.Accounts.Queries.GetCurrentUser;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Queries.GetCurrentUserName
{
    public class GetCurrentUserNameQueryHandler : IRequestHandler<GetCurrentUserNameQuery, string>
    {
        private readonly ICurrentUserService _currentUserService;
        public GetCurrentUserNameQueryHandler(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }
        public async Task<string> Handle(GetCurrentUserNameQuery request, CancellationToken cancellationToken)
        {
            return _currentUserService.UserName;
        }
    }
}
