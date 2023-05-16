using Application.UnitTests.Common;
using AutoMapper;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetail;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.UnitTests.Products.Queries.GetProductsBasicDetail
{
    public class GetProductsBasicDetailQueryHandlerTests : QueryTestFixtures
    {
        private readonly GetProductsBasicDetailQueryHandler _handler;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsBasicDetailQueryHandlerTests() : base()
        {
            _context = Context;
            _mapper = Mapper;

            _handler = new GetProductsBasicDetailQueryHandler(_context, _mapper);
        }

        [Fact]
        public async Task GetProductsBasicDetailQueryHandler_CanGetProductsBasicDetail()
        {
            // arrange
            var query = new GetProductsBasicDetailQuery();

            // act
            var result = _handler.Handle(query, CancellationToken.None);

            // assert
            Assert.NotNull(result);
        }
    }
}
