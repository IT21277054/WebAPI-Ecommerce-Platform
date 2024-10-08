// ====================================================
// File: IProductRepository.cs
// Description: Repository interface for handling product entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence
{
    // Repository interface for Product entities
    public interface IProductRepository : IGenericRepository<Product, Guid>
    {
        Task<List<Product>> GetByVendorId(Guid vendorId);
    }
}
