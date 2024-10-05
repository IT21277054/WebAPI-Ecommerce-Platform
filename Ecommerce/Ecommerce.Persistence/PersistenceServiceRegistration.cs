using Ecommerce.Persistence.DatabaseContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Persistence.Repository;

namespace Ecommerce.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EcommerceDBContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("EcommerceDBConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IInventoryRepository, InventoryRepository>();
        services.AddScoped<IOrderCancelationRepository, OrderCancelationRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserRolesRepository, UserRolesRepository>();
        services.AddScoped<IVendorFeedbackRepository, VendorFeedbackRepository>();
        services.AddScoped<IVendorRepository, VendorRepository>();

        return services;
    }
}
