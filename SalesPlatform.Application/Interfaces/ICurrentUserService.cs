using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    public interface ICurrentUserService
    {
        string UserName { get; set; }
        bool IsAuthenticated { get; set; }
        int UserId { get; set; }
        string UserRole { get; set; }
    }
}
