using Application.UnitTests.Common;
using Application.UnitTests.Mapping;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Moq;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Mapping;
using SalesPlatform.Application.Products.Commands.AddProduct;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentValidation.TestHelper;
using FluentAssertions;

namespace Application.UnitTests.Products.Commands.AddProduct
{
    public class AddProductCommandHandlerTests : CommandTestBase
    {
        private readonly AddProductCommandHandler _handler;
        private readonly IMapper _mapping;
        private readonly ICurrentUserService _currentUser;
        private readonly IImageUpload _imageUpload;
        private readonly AddProductCommandValidator _validator;

        public AddProductCommandHandlerTests() : base()
        {
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapping = configurationProvider.CreateMapper();

            _currentUser = CurrentUserFactory.MockCurrentUser().Object;
            _imageUpload = ImageUploadFactory.MockImageUpload().Object;
            _validator = new AddProductCommandValidator();

            _handler = new AddProductCommandHandler(_context, _mapping, _currentUser, _imageUpload);
        }

        [Fact]
        public async Task AddProductCommand_GivenValidRequest_ShouldInsertDirector()
        {
            var command = new AddProductCommand()
            {
                Product = new AddProductDto()
                {
                    Condition = SalesPlatform.Domain.Enums.ProductCondition.New,
                    Category = SalesPlatform.Domain.Enums.ProductCategory.Electronics,
                    Name = "Laptop",
                    Price = 99,
                    Quantity = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VAT = true,
                    ProducerName = "Toshiba",
                    Country = "Poland",
                    Color = "Red",
                },
                Images = new List<IFormFile>()
            };
            
            var result = await _handler.Handle(command, CancellationToken.None);

            var check = await _context.Products.FirstAsync(x => x.Id == result);

            Assert.NotNull(check);
        }

        [Fact]
        public void AddProductCommand_GivenInvalidRequest_ShouldHaveValidationError()
        {
            // arrange
            var command = new AddProductCommand()
            {
                Product = new AddProductDto()
                {
                    Condition = (ProductCondition)1000,
                    Category = (ProductCategory)1000,
                    Name = string.Empty,
                    Price = -1,
                    Quantity = -2,
                    Description = string.Empty,
                    VAT = false,
                    ProducerName = string.Empty,
                    Country = string.Empty,
                    Color = string.Empty,
                },
                Images = new List<IFormFile>()
            };

            // act
            var result = _validator.TestValidate(command);

            //assert
            result.ShouldHaveAnyValidationError();
        }

        [Fact]
        public void AddProductCommand_GivenInvalidRequest_ShouldNotHaveValidationError()
        {
            // arrange
            var command = new AddProductCommand()
            {
                Product = new AddProductDto()
                {
                    Condition = SalesPlatform.Domain.Enums.ProductCondition.New,
                    Category = SalesPlatform.Domain.Enums.ProductCategory.Electronics,
                    Name = "Laptop",
                    Price = 99,
                    Quantity = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VAT = true,
                    ProducerName = "Toshiba",
                    Country = "Poland",
                    Color = "Red",
                },
                Images = new List<IFormFile>()
            };

            // act
            var result = _validator.TestValidate(command);

            //assert
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
