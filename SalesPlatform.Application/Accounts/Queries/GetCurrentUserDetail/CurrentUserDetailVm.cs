namespace SalesPlatform.Application.Accounts.Queries.GetCurrentUserDetail
{
    public class CurrentUserDetailVm
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public int UserId { get; set; }
    }
}