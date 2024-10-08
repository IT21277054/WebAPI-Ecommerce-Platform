// ====================================================
// File: OrderCancelationRepository.cs
// Description: Repository for managing order cancellation entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

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
