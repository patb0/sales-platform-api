using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    public interface IGenerateJwtToken
    {
        string Generate(User user, IAuthenticationSettings authenticationSettings);
    }
}
