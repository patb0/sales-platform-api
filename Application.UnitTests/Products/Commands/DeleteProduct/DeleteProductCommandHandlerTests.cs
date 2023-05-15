using Application.UnitTests.Common;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Products.Commands.DeleteProduct;
using SalesPlatform.Domain.Exceptions;
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
        public async Task DeleteProductCommandHandler_GivenExistProductId_ShouldDeleteProduct()
        {
            // arrange
            var command = new DeleteProductCommand() { Id = 7 };

            // act
            var result = _handler.Handle(command, CancellationToken.None);

            var check = await _context.Products.FirstOrDefaultAsync(x => x.Id == command.Id 
                && x.StatusId == 1);

            // assert
            Assert.Null(check);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(99)]
        [InlineData(100)]
        public void DeleteProductCommandHandler_GivenNotExistProductId_ShouldThrowException(int id)
        {
            // arrange
            var command = new DeleteProductCommand() { Id = id };

            // act
            var result = _handler.Handle(command, CancellationToken.None);

            // assert
            Assert.ThrowsAsync<NotFoundProductException>(() => result);
        }
    }
}
