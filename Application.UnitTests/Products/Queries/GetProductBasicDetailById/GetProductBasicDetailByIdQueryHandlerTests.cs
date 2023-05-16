using Application.UnitTests.Common;
using AutoMapper;
using FluentValidation.TestHelper;
using SalesPlatform.Application.Mapping;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailById;
using SalesPlatform.Domain.Exceptions;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Products.Queries.GetProductBasicDetailById
{
    public class GetProductBasicDetailByIdQueryHandlerTests : QueryTestFixtures
    {
        private readonly GetProductBasicDetailByIdQueryHandler _handler;
        private readonly GetProductBasicDetailByIdQueryValidator _validator = new ();
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductBasicDetailByIdQueryHandlerTests() : base()
        {
            _context = Context;
            _mapper = Mapper;

            _handler = new GetProductBasicDetailByIdQueryHandler(_context, _mapper);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task GetProductBasicDetailByIdQueryHandler_GivenExistProductId_ShouldGetProductBasicDetail(int productId)
        {
            // arrange
            var query = new GetProductBasicDetailByIdQuery { ProductId = productId };

            // act
            var result = await _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(99)]
        [InlineData(1000)]
        public void GetProductBasicDetailByIdQueryHandler_GivenNotExistProductId_ShouldThrowException(int productId)
        {
            // arrange
            var query = new GetProductBasicDetailByIdQuery() { ProductId = productId };

            // act
            var result = _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.ThrowsAsync<NotFoundProductException>(() => result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(null)]
        public async Task GetProductBasicDetailByIdQueryHandler_GivenInvalidProductId_ShouldHaveValidationError(int productId)
        {
            // arrange
            var query = new GetProductBasicDetailByIdQuery() { ProductId = productId };

            // act
            var result = _validator.TestValidate(query);

            // assert
            result.ShouldHaveAnyValidationError();
        }
    }
}
