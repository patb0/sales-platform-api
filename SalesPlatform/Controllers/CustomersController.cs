using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Customers.Queries.GetCustomerDetail;

namespace SalesPlatform.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : ApiBaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetailViewModel>> GetCustomerDetail(int id)
        {
            var customer = await Mediator.Send(new GetCustomerDetailQuery() { CustomerId = id });
            return customer;
        }
    }
}
