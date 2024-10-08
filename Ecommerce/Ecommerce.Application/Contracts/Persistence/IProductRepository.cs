using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IProductRepository : IGenericRepository<Product, Guid>
{
    Task<List<Product>> GetByVendorId(Guid vendorId);
}
