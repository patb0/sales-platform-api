using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Opinions.Queries;

namespace SalesPlatform.Controllers
{
    [Route("api/opinion")]
    public class OpinionController : ApiBaseController
    {
        [HttpGet("{productId}")]
        public async Task<ActionResult> GetOpinionsByProductId(int productId)
        {
            var opinions = await Mediator.Send(
                new GetOpinionsByProductIdQuery
                {
                    ProductId = productId
                });

            return Ok(opinions);
        }
    }
}
