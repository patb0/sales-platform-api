using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Accounts.Commands.LoginUser;
using SalesPlatform.Application.Accounts.Commands.RegisterUser;
using SalesPlatform.Application.Accounts.Queries.GetCurrentUser;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
using SalesPlatform.Infrastructure.Persistence;
using System.Security.Claims;

namespace SalesPlatform.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ApiBaseController
    {
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody]RegisterUserCommand registerUser)
        {
            var result = await Mediator.Send(registerUser);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginUserCommand loginUser)
        {
            var result = await Mediator.Send(loginUser);

            return Ok(result);
        }

        [HttpGet("user")]
        public async Task<ActionResult<string>> GetCurrentUser()
        {
            var currentUserName = await Mediator.Send(new GetCurrentUserNameQuery());
            
            return Ok(currentUserName);
        }

        [HttpGet("test")]
        public async Task<ActionResult<int>> Test()
        {
            //zmień
            var user = HttpContext.User.FindFirst("id").Value;

            return 1;
        }
    }
}
