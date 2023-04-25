using SalesPlatform.Application.Interfaces;
using System.Security.Claims;
using System.Xml.Linq;

namespace SalesPlatform.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public string UserName { get; set; }
        public bool IsAuthenticated{ get; set; } 
        public int UserId { get; set; }
        public string UserRole { get; set; }
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            //if user is authenticated = username else = guest
            var userName = httpContextAccessor.HttpContext?.User?.FindFirstValue("name");

            UserName = string.IsNullOrEmpty(userName) ? "Guest" : userName;


            //if authenticated
            IsAuthenticated = !string.IsNullOrEmpty(userName);

            //user id and role if authenticated
            if (IsAuthenticated)
            {

                var userId = int.Parse(httpContextAccessor.HttpContext?.User?.FindFirstValue("id"));

                UserId = userId;

                var userRole = httpContextAccessor.HttpContext?.User?.FindFirstValue("role");

                UserRole = userRole;
            }
            else
            {
                UserId = 0;
                UserRole = "Guest";
            }
        }
    }
}
