using Application.UnitTests.Common;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Products.Commands.DeleteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandlerTests : CommandTestBase
    {
        private readonly DeleteProductCommandHandler _handler;

        public DeleteProductCommandHandlerTests() : base()
        {
            _handler = new DeleteProductCommandHandler(_context);
        }

        [Fact]
        public async Task DeleteProduct_GivenValidProductId_ShouldDeleteProduct()
        {
            // arrange
            var command = new DeleteProductCommand() { Id = 7 };

            // act
            var result = _handler.Handle(command, CancellationToken.None);

            var check = await _context.Products.FirstAsync(x => x.Id == command.Id);

            // assert
            Assert.Null(check);
        }
    }
}
