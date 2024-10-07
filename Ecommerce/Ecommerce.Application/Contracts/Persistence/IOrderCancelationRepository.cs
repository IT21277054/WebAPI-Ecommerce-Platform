using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IOrderCancelationRepository : IGenericRepository<OrderCancelation, Guid>
{
}
