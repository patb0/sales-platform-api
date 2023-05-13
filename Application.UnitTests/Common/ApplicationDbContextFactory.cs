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
            // mock for date time
            var dateTime = new DateTime(2023, 1, 1);
            var dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.Now).Returns(dateTime);
            //mock for current user
            var currentUserMock = new Mock<ICurrentUserService>();
            currentUserMock.Setup(m => m.UserRole).Returns("Admin");
            currentUserMock.Setup(m => m.IsAuthenticated).Returns(true);
            currentUserMock.Setup(m => m.UserName).Returns("Administrator");
            //use db in memory
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            //mock for db context with constructor arguments
            var mock = new Mock<ApplicationDbContext>(options, dateTimeMock.Object, currentUserMock.Object);

            var context = mock.Object;
            //check if db is created
            context.Database.EnsureCreated();

            //todo: add entities to db for tests

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
