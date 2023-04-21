using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Accounts.Commands.RegisterUser;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
using SalesPlatform.Infrastructure.Persistence;

namespace SalesPlatform.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ApiBaseController
    {
        private readonly IApplicationDbContext _context;
        public AccountController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterUserCommand registerUser)
        {
            var result = await Mediator.Send(registerUser);

            return Ok(result);
        }
    }
}
