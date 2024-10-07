using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class ProductRepository : GenericRepository<Product, Guid>, IProductRepository
{
    public ProductRepository(EcommerceDBContext context) : base(context)
    {
    }
}
