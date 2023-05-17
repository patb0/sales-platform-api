using Application.UnitTests.Common;
using AutoMapper;
using FluentValidation.TestHelper;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey;
using SalesPlatform.Domain.Exceptions;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Products.Queries.GetProductBasicDetailBySearchKey
{
    public class GetProductBasicDetailBySearchKeyQueryHandlerTests : QueryTestFixtures
    {
        private readonly GetProductDetailBySearchKeyQueryHandler _handler;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly GetProductDetailBySearchKeyQueryValidator _validator;
        public GetProductBasicDetailBySearchKeyQueryHandlerTests() : base()
        {
            _context = Context;
            _mapper = Mapper;
            _validator = new GetProductDetailBySearchKeyQueryValidator();

            _handler = new GetProductDetailBySearchKeyQueryHandler(_context, _mapper);
        }

        [Theory]
        [InlineData("Asus")]
        [InlineData("name")]
        public async Task GetProductDetailBySearchKeyQueryHandler_GivenValidRequest_ShouldGetProductBasicDetail(string searchKey)
        {
            // arrange
            var query = new GetProductDetailBySearchKeyQuery { SearchKey = searchKey };

            // act
            var result = await _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("xxxxxx")]
        [InlineData(null)]
        public async Task GetProductDetailBySearchKeyQueryHandler_GivenInvalidRequest_ShouldThrowExcpetion(string searchKey)
        {
            // arrange
            var query = new GetProductDetailBySearchKeyQuery { SearchKey = searchKey };

            // act
            var result = _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.ThrowsAnyAsync<NotFoundProductException>(() => result);
        }

        [Theory]
        [InlineData("Product name")]
        [InlineData("Laptop")]
        public void GetProductDetailBySearchKeyQueryHandler_GivenValidSearchKey_ShouldNotHaveValidationError(string searchKey)
        {
            // arrange
            var query = new GetProductDetailBySearchKeyQuery() {   SearchKey = searchKey };

            // act
            var result = _validator.TestValidate(query);

            // assert 
            result.ShouldNotHaveAnyValidationErrors();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("qazwsxedcrfvtgbyhnujm")]
        public void GetProductDetailBySearchKeyQueryHandler_GivenInvalidSearchKey_ShouldHaveValidationError(string searchKey)
        {
            // arrange
            var query = new GetProductDetailBySearchKeyQuery() { SearchKey = searchKey };

            // act
            var result = _validator.TestValidate(query);

            // assert 
            result.ShouldHaveAnyValidationError();
        }
    }
}
