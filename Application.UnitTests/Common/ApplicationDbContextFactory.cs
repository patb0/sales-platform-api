using Microsoft.EntityFrameworkCore;
using Moq;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public static class ApplicationDbContextFactory
    {
        public static Mock<ApplicationDbContext> Create()
        {
            var MockDateTime = DateTimeFactory.MockDateTime().Object;
            var MockCurrentUser = CurrentUserFactory.MockCurrentUser().Object;
            // mock for date time
            //var dateTime = new DateTime(2023, 1, 1);
            //var dateTimeMock = new Mock<IDateTime>();
            //dateTimeMock.Setup(m => m.Now).Returns(dateTime);

            //mock for current user
            //var currentUserMock = new Mock<ICurrentUserService>();
            //currentUserMock.Setup(m => m.UserRole).Returns("Admin");
            //currentUserMock.Setup(m => m.IsAuthenticated).Returns(true);
            //currentUserMock.Setup(m => m.UserName).Returns("Administrator");

            //use db in memory
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("UserContextWithNullCheckingDisabled", b => b.EnableNullChecks(false))
                .Options;

            //mock for db context with constructor arguments
            var mock = new Mock<ApplicationDbContext>(options, MockDateTime, MockCurrentUser) { CallBase = true };

            var context = mock.Object;

            //check if db is created
            context.Database.EnsureCreated();

            //add entities to db for tests
            var account = new Account()
            {
                Id = 6,
                Login = "patryk",
                PasswordHash = "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==",
                RoleId = 1,
            };
            context.Accounts.Add(account);

            var contact = new Contact()
            {
                Id = 7,
                PhoneNumber = "992003991",
                EmailAddress = "adas@pl.com",
            };
            context.Contacts.Add(contact);

            var address = new Address()
            {
                Id = 7,
                Country = SalesPlatform.Domain.Enums.Country.Poland,
                ZipCode = "00-000",
                City = "Warsaw",
                Street = "Kwiatowa",
                FlatNumber = "1a",
            };
            context.Addresses.Add(address);

            var image = new Image()
            {
                Id = 7,
                Height = 500,
                Width = 500,
                Url = @"https://res.cloudinary.com/dshks90xq/image/upload/v1683881795/Electronics_h49ron.jpg",
                ProductId = 7,
            };
            context.Images.Add(image);

            var opinion = new Opinion()
            {
                Id = 6,
                Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Rating = 5,
                ProductId = 7,
                AddedBy = "Patryk Boguslawski",
            };
            context.Opinions.Add(opinion);

            var product = new Product()
            {
                Id = 7,
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = "Admin",
                UserId = 6,
                Condition = SalesPlatform.Domain.Enums.ProductCondition.New,
                Category = SalesPlatform.Domain.Enums.ProductCategory.Electronics,
                Name = "Product name6",
                Price = 389,
                Quantity = 1,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                VAT = true,
                ProductDetail = new SalesPlatform.Domain.ValueObjects.ProductDetail("Asus", "Poland", "Red")
            };
            context.Products.Add(product);

            var user = new User()
            {
                Id = 6,
                StatusId = 1,
                Created = DateTime.Now,
                CreatedBy = "Admin",
                ContactId = 7,
                AddressId = 7,
                AccountId = 6,
            };
            context.Users.Add(user);

            context.SaveChanges();

            return mock;
        }

        public static void Destroy(ApplicationDbContext context)
        {
            //delete db
            context.Database.EnsureDeleted();
            //memory release
            context.Dispose();
        }
    }
}
