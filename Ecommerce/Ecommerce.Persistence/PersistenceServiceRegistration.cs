using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoClient = new MongoClient("mongodb+srv://ShamryShiraz:123@nasa.zisfxs2.mongodb.net/?retryWrites=true&w=majority&appName=Nasa");

        services.AddDbContext<EcommerceDBContext>(options =>
        {
            options.UseMongoDB(mongoClient, "Ecommerce");
        });

        // Register repositories
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
        services.AddScoped<ICartRepository, CartRepository>();

        return services;
    }
}
