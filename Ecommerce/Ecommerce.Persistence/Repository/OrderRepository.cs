// ====================================================
// File: OrderRepository.cs
// Description: Repository for managing order entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class OrderRepository : GenericRepository<Order, Guid>, IOrderRepository
{
    public OrderRepository(EcommerceDBContext context) : base(context)
    {
    }
}
