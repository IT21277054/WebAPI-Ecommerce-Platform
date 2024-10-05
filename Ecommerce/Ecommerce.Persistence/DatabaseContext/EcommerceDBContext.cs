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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);



        modelBuilder.Entity<Category>().ToCollection("categories");
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
