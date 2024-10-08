// ====================================================
// File: ProductRepository.cs
// Description: Repository for managing product entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class ProductRepository : GenericRepository<Product, Guid>, IProductRepository
{
    private readonly EcommerceDBContext _context;

    public ProductRepository(EcommerceDBContext context) : base(context)
    {
        _context = context; // Initialize the database context
    }

    // Retrieve a list of products by the specified vendor ID
    public async Task<List<Product>> GetByVendorId(Guid vendorId)
    {
        return await _context.Product
            .Where(product => product.VendorId == vendorId) // Filter products by vendor ID
            .ToListAsync(); // Return the filtered list of products
    }
}
