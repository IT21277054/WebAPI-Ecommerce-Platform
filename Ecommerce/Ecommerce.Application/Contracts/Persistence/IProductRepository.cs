using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IProductRepository : IGenericRepository<Product, Guid>
{
    Task<Product> GetByVendorId(Guid vendorId);
}
