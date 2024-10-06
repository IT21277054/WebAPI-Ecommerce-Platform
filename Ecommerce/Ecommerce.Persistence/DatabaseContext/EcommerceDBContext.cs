using Ecommerce.Domain;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Ecommerce.Persistence.DatabaseContext;

public class EcommerceDBContext : DbContext
{
    public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options): base(options) 
    {

    }

    public DbSet<Category> Category {  get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderCancelation> OrderCancelation { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }
    public DbSet<Vendor> Vendor { get; set; }
    public DbSet<VendorFeedback> VendorFeedback { get; set; }
    public DbSet<Cart> Cart { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Ignore<IBaseEntity>();

        modelBuilder.Entity<Category>().ToCollection(nameof(Category));
        modelBuilder.Entity<Inventory>().ToCollection(nameof(Inventory));
        modelBuilder.Entity<Order>().ToCollection(nameof(Order));
        modelBuilder.Entity<OrderCancelation>().ToCollection(nameof(OrderCancelation));
        modelBuilder.Entity<Product>().ToCollection(nameof(Product));
        modelBuilder.Entity<User>().ToCollection(nameof(User));
        modelBuilder.Entity<UserRoles>().ToCollection(nameof(UserRoles));
        modelBuilder.Entity<Vendor>().ToCollection(nameof(Vendor));
        modelBuilder.Entity<VendorFeedback>().ToCollection(nameof(VendorFeedback));
        modelBuilder.Entity<Cart>().ToCollection(nameof(Cart));
    }


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<IBaseEntity>()
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
