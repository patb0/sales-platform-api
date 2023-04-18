using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetail;
using SalesPlatform.Application.Products.Queries.GetProductsFullDetail;

namespace SalesPlatform.Controllers
{
    [Route("api/products")]
    public class ProductsController : ApiBaseController
    {
        [HttpGet("full")]
        public async Task<ActionResult> GetProductsFullDetail()
        {
            var products = await Mediator.Send(new GetProductsFullDetailQuery());

            return Ok(products);
        }

        [HttpGet("basic")]
        public async Task<ActionResult> GetProductsBasicDetai()
        {
            var products = await Mediator.Send(new GetProductsBasicDetailQuery());

            return Ok(products);
        }
    }
}
