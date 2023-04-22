using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    public interface IGenerateUserJwt
    {
        string GenerateJwtToken(User user);
    }
}
