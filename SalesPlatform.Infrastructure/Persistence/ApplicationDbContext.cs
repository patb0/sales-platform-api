using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Domain.Common;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IDateTime _dateTime;
        private readonly ICurrentUserService _currentUser;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTime dateTime, ICurrentUserService currentUser) : base(options)
        {
            _dateTime = dateTime;
            _currentUser = currentUser;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure value objects in entities 
            modelBuilder.Entity<Product>()
                .OwnsOne(x => x.ProductDetail);

            modelBuilder.Entity<User>()
                .OwnsOne(x => x.UserName);

            //added entities configuration during excecuting
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedData();
        }

        public int SaveChangesWithAuditable()
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.CreatedBy = _currentUser.UserName;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.ModifiedBy = _currentUser.UserName;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.ModifiedBy = _currentUser.UserName;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = _currentUser.UserName;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChanges();
        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    //entity tracker + auto uzupelnianie
        //    foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        //    {
        //        switch(entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.Entity.Created = _dateTime.Now;
        //                entry.Entity.CreatedBy = "Admin";
        //                entry.Entity.StatusId = 1;
        //                break;
        //            case EntityState.Modified:
        //                entry.Entity.Modified = _dateTime.Now;
        //                entry.Entity.ModifiedBy = "Admin";
        //                break;
        //            case EntityState.Deleted:
        //                entry.Entity.Modified = _dateTime.Now;
        //                entry.Entity.ModifiedBy = "Admin";
        //                entry.Entity.Inactivated = _dateTime.Now;
        //                entry.Entity.InactivatedBy = "Admin";
        //                entry.Entity.StatusId = 0;
        //                entry.State = EntityState.Modified;
        //                break;
        //        }
        //    }
        //    //return base.SaveChangesAsync(cancellationToken);
        //}
    }
}