﻿// ====================================================
// File: IOrderRepository.cs
// Description: Repository interface for handling order entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence
{
    // Repository interface for Order entities
    public interface IOrderRepository : IGenericRepository<Order, Guid>
    {
    }
}
