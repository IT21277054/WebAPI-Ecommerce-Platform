// ====================================================
// File: IOrderCancelationRepository.cs
// Description: Repository interface for handling order cancellation entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence
{
    // Repository interface for OrderCancelation entities
    public interface IOrderCancelationRepository : IGenericRepository<OrderCancelation, Guid>
    {
    }
}
