﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Accounts.Queries.GetCurrentUserDetail
{
    public class GetCurrentUserDetailQuery : IRequest<CurrentUserDetailVm>
    {
    }
}
