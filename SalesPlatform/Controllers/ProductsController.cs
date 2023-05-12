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

        [HttpGet("{id}/full-detail")]
        public async Task<ActionResult> GetProductFullDetailById([FromRoute]int id)
        {
            var product = await Mediator.Send(
                new GetProductFullDetailByIdQuery
                {
                    ProductId = id
                });

            return Ok(product);
        }

        [HttpGet("{id}/basic-detail")]
        public async Task<ActionResult> GetProductBasicDetailById([FromRoute] int id)
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
        public async Task<ActionResult> AddProduct([FromForm]AddProductDto product, [FromQuery]ICollection<IFormFile> images)
        {
            var result = await Mediator.Send(
                new AddProductCommand
                {
                    Product = product,
                    Images = images
                });

            return Ok($"Product with id: {result} was added!");
        }

        //to change
        [Authorize]
        [HttpPatch("{id}")]
        public async Task<ActionResult> UpdateProduct([FromRoute]int id, [FromBody]UpdateProductDto updateProduct)
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
        public async Task<ActionResult> DeleteProduct([FromRoute]int id)
        {
            var result = await Mediator.Send(
                new DeleteProductCommand
                {
                    Id = id 
                });

            return Ok("Successful, product was deleted!");
        }
    }
}
