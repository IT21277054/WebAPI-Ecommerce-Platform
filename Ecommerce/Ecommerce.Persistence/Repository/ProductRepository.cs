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
        _context = context;
    }

    public async Task<List<Product>> GetByVendorId(Guid vendorId)
    {
        return await _context.Product
            .Where(product => product.VendorId == vendorId)
            .ToListAsync();
    }

}
