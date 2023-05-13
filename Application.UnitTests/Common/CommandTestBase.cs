using Moq;
using SalesPlatform.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        protected readonly ApplicationDbContext _context;
        protected readonly Mock<ApplicationDbContext> _contextMock;
        public CommandTestBase()
        {
            _contextMock = ApplicationDbContextFactory.Create();
            _context = _contextMock.Object;
        }

        public void Dispose()
        {
            ApplicationDbContextFactory.Destroy(_context);
        }
    }
}
