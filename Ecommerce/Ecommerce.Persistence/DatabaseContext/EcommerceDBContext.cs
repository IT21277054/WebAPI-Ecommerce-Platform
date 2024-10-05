using Ecommerce.Domain;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.DatabaseContext;

public class EcommerceDBContext : DbContext
{
    public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options): base(options) 
    {

    }

    public DbSet<Category> Category {  get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<OrderCancelation> OrderCancelation { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }
    public DbSet<Vendor> Vendor { get; set; }
    public DbSet<VendorFeedback> VendorFeedback { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.ModifiedOn = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedOn = DateTime.Now;
            }

        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
