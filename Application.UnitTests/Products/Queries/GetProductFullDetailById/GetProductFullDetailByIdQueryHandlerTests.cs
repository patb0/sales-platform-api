using Application.UnitTests.Common;
using AutoMapper;
using FluentValidation.TestHelper;
using SalesPlatform.Application.Products.Queries.GetProductFullDetailById;
using SalesPlatform.Domain.Exceptions;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Products.Queries.GetProductFullDetailById
{
    public class GetProductFullDetailByIdQueryHandlerTests : QueryTestFixtures
    {
        private readonly GetProductFullDetailByIdQueryHandler _handler;
        private readonly GetProductFullDetailByIdQueryValidator _validator = new ();
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductFullDetailByIdQueryHandlerTests() : base()
        {
            _context = Context;
            _mapper = Mapper;

            _handler = new GetProductFullDetailByIdQueryHandler(_context, _mapper);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async Task GetProductFullDetailByIdQueryHandler_GivenValidRequest_ShouldGetProductFullDetail(int productId)
        {
            // arrange 
            var query = new GetProductFullDetailByIdQuery { ProductId = productId };

            // act
            var result = await _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task GetProductFullDetailByIdQueryHandler_GivenInvalidRequest_ShouldThrowException(int productId)
        {
            // arrange 
            var query = new GetProductFullDetailByIdQuery { ProductId = productId };

            // act
            var result =  _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.ThrowsAnyAsync<NotFoundProductException>(() => result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async Task GetProductFullDetailByIdQueryHandler_GivenValidProductId_ShouldNotHaveValidationError(int productId)
        {
            // arrange 
            var query = new GetProductFullDetailByIdQuery { ProductId = productId };

            // act
            var result = _validator.TestValidate(query);

            // assert
            result.ShouldNotHaveAnyValidationErrors();
        }

        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        public async Task GetProductFullDetailByIdQueryHandler_GivenInvalidProductId_ShouldHaveValidationError(int productId)
        {
            // arrange 
            var query = new GetProductFullDetailByIdQuery { ProductId = productId };

            // act
            var result = _validator.TestValidate(query);

            // assert
            result.ShouldHaveAnyValidationError();
        }
    }
}
