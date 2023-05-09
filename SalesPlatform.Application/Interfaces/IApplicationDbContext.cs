using Microsoft.EntityFrameworkCore;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Opinion> Opinions { get; set; }
        DbSet<Image> Images { get; set; }

        int SaveChangesWithAuditable();
        int SaveChanges();
        void AddRange(IEnumerable<object> entities);
    }
}
