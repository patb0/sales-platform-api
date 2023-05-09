using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Accounts.Commands.LoginUser;
using SalesPlatform.Application.Accounts.Commands.RegisterUser;
using SalesPlatform.Application.Accounts.Queries.GetCurrentUser;
using SalesPlatform.Application.Accounts.Queries.GetCurrentUserDetail;
using SalesPlatform.Application.Accounts.Queries.GetCurrentUserId;
using SalesPlatform.Application.Accounts.Queries.GetCurrentUserRole;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
using SalesPlatform.Infrastructure.Persistence;
using System.Security.Claims;

namespace SalesPlatform.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountsController : ApiBaseController
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

        [HttpGet("name")]
        public async Task<ActionResult<string>> GetCurrentUserName()
        {
            var currentUserName = await Mediator.Send(new GetCurrentUserNameQuery());
            
            return Ok(currentUserName);
        }

        [HttpGet("id")]
        public async Task<ActionResult<int>> GetCurrentUserId()
        {
            var currentUserId = await Mediator.Send(new GetCurrentUserIdQuery());

            return Ok(currentUserId);
        }

        [HttpGet("role")]
        public async Task<ActionResult<string>> GetCurrentUserRole()
        {
            var currentUserRole = await Mediator.Send(new GetCurrentUserRoleQuery());

            return Ok(currentUserRole);
        }

        [HttpGet("detail")]
        public async Task<ActionResult> GetCurrentUserDetails()
        {
            var currentUserDetail = await Mediator.Send(new GetCurrentUserDetailQuery());

            return Ok(currentUserDetail);
        }
    }
}
