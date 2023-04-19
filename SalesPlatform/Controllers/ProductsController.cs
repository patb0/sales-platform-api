using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetail;
using SalesPlatform.Application.Products.Queries.GetProductsFullDetail;
using SalesPlatform.Application.Products.Queries.GetProductFullDetailById;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailById;

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
        public async Task<ActionResult> GetProductsBasicDetail()
        {
            var products = await Mediator.Send(new GetProductsBasicDetailQuery());

            return Ok(products);
        }

        [HttpGet("{id}/full")]
        public async Task<ActionResult> GetProductFullDetailById(int id)
        {
            var product = await Mediator.Send(new GetProductFullDetailByIdQuery { ProductId = id});
            
            return Ok(product);
        }

        [HttpGet("{id}/basic")]
        public async Task<ActionResult> GetProductBasicDetailById(int id)
        {
            var product = await Mediator.Send(new GetProductBasicDetailByIdQuery { ProductId = id });

            return Ok(product);
        }
    }
}
