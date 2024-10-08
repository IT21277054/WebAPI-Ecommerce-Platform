// ====================================================
// File: ICartRepository.cs
// Description: Interface for Cart repository operations.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// ICartRepository extends the generic repository interface for Cart entities.
public interface ICartRepository : IGenericRepository<Cart, Guid>
{
    // Additional methods specific to Cart repository can be added here if needed.
}
