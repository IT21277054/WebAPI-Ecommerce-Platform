using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class OrderCancelationRepository : GenericRepository<OrderCancelation, Guid>, IOrderCancelationRepository
{
    public OrderCancelationRepository(EcommerceDBContext context) : base(context)
    {
    }
}
