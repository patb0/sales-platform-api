using SalesPlatform.Application.Interfaces;
using System.Security.Claims;

namespace SalesPlatform.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public string UserName { get; set; }
        public bool IsAuthenticated{ get; set; } 
        public int UserId { get; set; }
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            //if user is authenticated = username else = guest
            var userName = httpContextAccessor.HttpContext?.User?.Identity?.Name;

            UserName = string.IsNullOrEmpty(userName) ? "Guest" : userName;


            //if authenticated
            IsAuthenticated = !string.IsNullOrEmpty(userName);

            //user id if authenticated
            if (IsAuthenticated)
            {
                //change this
                //var user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                UserId = int.Parse(httpContextAccessor.HttpContext.User.FindFirstValue("id"));
            }

        }
    }
}
