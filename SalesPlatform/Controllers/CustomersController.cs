using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Customers.Queries.GetCustomerFullDetail;
using SalesPlatform.Application.Interfaces;

namespace SalesPlatform.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : ApiBaseController
    {
        [HttpGet("id")]
        public async Task<ActionResult<CustomerFullDetailViewModel>> GetCustomerDetail(int id)
        {
            var customer = await Mediator.Send(new GetCustomerFullDetailQuery() { CustomerId = id });

            return customer;
        }
    }
}
