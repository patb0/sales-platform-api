using Application.UnitTests.Common;
using FluentValidation.TestHelper;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Opinions.Commands.AddProductOpinion;
using SalesPlatform.Domain.Exceptions;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Opinions.Commands
{
    public class AddProductOpinionCommandHandlerTests : CommandTestBase
    {
        private readonly AddProductOpinionCommandHandler _handler;
        private readonly ICurrentUserService _currentUser;
        private readonly AddProductOpinionCommandValidator _validator;

        public AddProductOpinionCommandHandlerTests() : base()
        {
            _currentUser = CurrentUserFactory.MockCurrentUser().Object;
            _validator = new AddProductOpinionCommandValidator();

            _handler = new AddProductOpinionCommandHandler(_context, _currentUser);
        }

        [Theory]
        [InlineData(1, 5, "Good")]
        [InlineData(3, 1, "Not good")]
        public async Task AddProductOpinionCommandHandler_GivenValidRequest_ShouldInsertOpinionToProduct(
            int productId, int rating, string comment)
        {
            // arrange
            var command = new AddProductOpinionCommand() 
            { 
                ProductId = productId, 
                Rating = rating, 
                Comment = comment 
            };

            // act
            var result = await _handler.Handle(command, CancellationToken.None);

            var check = await _context.Opinions.FirstAsync(x => x.Id == result);

            // assert
            Assert.NotNull(check);
        }

        [Theory]
        [InlineData(1, 2, "Goooooood!")]
        [InlineData(3, 5, "I recommend!")]
        public void AddProductOpinionCommandHandler_GivenValidRequest_ShouldNotHaveValidationError(
            int productId, int rating, string comment)
        {
            // arrange
            var command = new AddProductOpinionCommand()
            {
                ProductId = productId,
                Rating = rating,
                Comment = comment
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldNotHaveAnyValidationErrors();
        }

        [Theory]
        [InlineData(-1, -1, null)]
        [InlineData(0, 0, "")]
        public void AddProductOpinionCommandHandler_GivenInvalidRequest_ShouldHaveValidationError(
            int productId, int rating, string comment)
        {
            // arrange
            var command = new AddProductOpinionCommand()
            {
                ProductId = productId,
                Rating = rating,
                Comment = comment
            };

            // act
            var result = _validator.TestValidate(command);

            // assert
            result.ShouldHaveAnyValidationError();
        }

        [Theory]
        [InlineData(99999, 5, "Good")]
        [InlineData(1000000, 1, "Good")]
        public async void AddProductOpinionCommandHandler_GivenInvalidProductId_ShouldThrowException(
            int productId, int rating, string comment)
        {
            // arrange
            var command = new AddProductOpinionCommand()
            {
                ProductId = productId,
                Rating = rating,
                Comment = comment
            };

            // act
            var result = _handler.Handle(command, CancellationToken.None);

            // assert
            Assert.ThrowsAnyAsync<NotFoundProductException>(() => result);
        }
    }
}
