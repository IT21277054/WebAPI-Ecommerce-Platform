using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class CartRepository : GenericRepository<Cart, Guid>, ICartRepository
{
    public CartRepository(EcommerceDBContext context) : base(context)
    {
    }
}
