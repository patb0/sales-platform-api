using Application.UnitTests.Common;
using AutoMapper;
using FluentValidation.TestHelper;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Opinions.Queries.GetOpinionsByProductId;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Opinions.Queries
{
    public class GetOpinionsByProductIdQueryHandlerTests : QueryTestFixtures
    {
        private readonly GetOpinionsByProductIdQueryHandler _handler;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly GetOpinionsByProductIdQueryValidator _validator;
        public GetOpinionsByProductIdQueryHandlerTests() : base()
        {
            _context = Context;
            _mapper = Mapper;
            _validator = new GetOpinionsByProductIdQueryValidator();

            _handler = new GetOpinionsByProductIdQueryHandler(_context, _mapper);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public async Task GetOpinionsByProductIdQueryHandler_GivenExistProductId_ShouldGetProductOpinion(int productId)
        {
            // arrange
            var query = new GetOpinionsByProductIdQuery() { ProductId = productId };

            // act
            var result = await _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(999)]
        [InlineData(100)]
        [InlineData(29)]
        public async Task GetOpinionsByProductIdQueryHandler_GivenNotExistProductId_ShouldThrowException(int productId)
        {
            // arrange
            var query = new GetOpinionsByProductIdQuery() { ProductId = productId };

            // act
            var result = _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.ThrowsAnyAsync<NotFoundOpinionException>(() => result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public async Task GetOpinionsByProductIdQueryHandler_GivenInvalidProductId_ShouldHaveValidationError(int productId)
        {
            // arrange
            var query = new GetOpinionsByProductIdQuery() { ProductId = productId };

            // act
            var result = _validator.TestValidate(query);

            // assert
            result.ShouldHaveAnyValidationError();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(40)]
        public async Task GetOpinionsByProductIdQueryHandler_GivenValidProductId_ShouldNotHaveValidationError(int productId)
        {
            // arrange
            var query = new GetOpinionsByProductIdQuery() { ProductId = productId };

            // act
            var result = _validator.TestValidate(query);

            // assert
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
