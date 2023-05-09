using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Opinions.Commands.AddProductOpinion;
using SalesPlatform.Application.Opinions.Queries.GetOpinionsByProductId;

namespace SalesPlatform.Controllers
{
    [Route("api/opinion")]
    public class OpinionsController : ApiBaseController
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

        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<int>> AddProductOpinion([FromBody]AddProductOpinionCommand productOpinion)
        {
            var result = Mediator.Send(productOpinion);

            return Ok(result.Result);
        }
    }
}
