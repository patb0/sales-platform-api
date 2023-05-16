using Application.UnitTests.Common;
using AutoMapper;
using SalesPlatform.Application.Products.Queries.GetProductsFullDetail;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Products.Queries.GetProductsFullDetail
{
    public class GetProductsFullDetailQueryHandlerTests : QueryTestFixtures
    {
        private readonly GetProductsFullDetailQueryHandler _handler;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsFullDetailQueryHandlerTests() : base()
        {
            _context = Context;
            _mapper = Mapper;

            _handler = new GetProductsFullDetailQueryHandler(_context, _mapper);
        }

        [Fact]
        public async Task GetProductsFullDetailQueryHandler_CanGetProductsFullDetail()
        {
            // arrange
            var query = new GetProductsFullDetailQuery();

            // act
            var result = await _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }
    }
}
