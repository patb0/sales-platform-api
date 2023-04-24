using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetail;
using SalesPlatform.Application.Products.Queries.GetProductsFullDetail;
using SalesPlatform.Application.Products.Queries.GetProductFullDetailById;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailById;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey;
using Microsoft.AspNetCore.Authorization;

namespace SalesPlatform.Controllers
{
    [Route("api/products")]
    public class ProductsController : ApiBaseController
    {
        [HttpGet("full-detail")]
        public async Task<ActionResult> GetProductsFullDetail()
        {
            var products = await Mediator.Send(new GetProductsFullDetailQuery());

            return Ok(products);
        }

        [HttpGet("basic-detail")]
        public async Task<ActionResult> GetProductsBasicDetail()
        {
            var products = await Mediator.Send(new GetProductsBasicDetailQuery());

            return Ok(products);
        }

        [HttpGet("{id:int:min(1)}/full-detail")]
        public async Task<ActionResult> GetProductFullDetailById(int id)
        {
            var product = await Mediator.Send(new GetProductFullDetailByIdQuery { ProductId = id});
            
            return Ok(product);
        }

        [HttpGet("{id:int:min(1)}/basic-detail")]
        public async Task<ActionResult> GetProductBasicDetailById(int id)
        {
            var product = await Mediator.Send(new GetProductBasicDetailByIdQuery { ProductId = id });

            return Ok(product);
        }

        [HttpGet("search")]
        public async Task<ActionResult> GetProductsBySearchKey(string searchKey)
        {
            var products = await Mediator.Send(new GetProductDetailBySearchKeyQuery { SearchKey = searchKey });

            return Ok(products);
        }
    }
}
