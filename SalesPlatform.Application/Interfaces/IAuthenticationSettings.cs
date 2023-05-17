using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    public interface IAuthenticationSettings
    {
        string JwtKey { get; set; }
        string JwtIssuer { get; set; }
        int JwtExpireDays { get; set; }
    }
}
