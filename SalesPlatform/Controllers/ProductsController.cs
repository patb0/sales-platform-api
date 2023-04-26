using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetail;
using SalesPlatform.Application.Products.Queries.GetProductsFullDetail;
using SalesPlatform.Application.Products.Queries.GetProductFullDetailById;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailById;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey;
using Microsoft.AspNetCore.Authorization;
using SalesPlatform.Application.Products.Commands.AddProduct;
using SalesPlatform.Application.Products.Commands.UpdateProduct;
using SalesPlatform.Application.Products.Commands.DeleteProduct;

namespace SalesPlatform.Controllers
{
    [Route("api/product")]
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

        [HttpGet("{id}/full-detail")]
        public async Task<ActionResult> GetProductFullDetailById(int id)
        {
            var product = await Mediator.Send(
                new GetProductFullDetailByIdQuery 
                { 
                    ProductId = id 
                });

            return Ok(product);
        }

        [HttpGet("{id}/basic-detail")]
        public async Task<ActionResult> GetProductBasicDetailById(int id)
        {
            var product = await Mediator.Send(
                new GetProductBasicDetailByIdQuery 
                {
                    ProductId = id 
                });

            return Ok(product);
        }

        [HttpGet("search")]
        public async Task<ActionResult> GetProductsBySearchKey(string searchKey)
        {
            var products = await Mediator.Send(
                new GetProductDetailBySearchKeyQuery 
                { 
                    SearchKey = searchKey 
                });

            return Ok(products);
        }

        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult> AddProduct(AddProductCommand addProduct)
        {
            var result = await Mediator.Send(addProduct);

            return Ok(result);
        }

        [Authorize]
        [HttpPatch("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody]UpdateProductDto updateProduct)
        {
            var result = await Mediator.Send(
                new UpdateProductCommand 
                {
                    Id = id,
                    Product = updateProduct
                });

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var result = await Mediator.Send(
                new DeleteProductCommand
                {
                    Id = id 
                });

            return Ok();
        }
    }
}
