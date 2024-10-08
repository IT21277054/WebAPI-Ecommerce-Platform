// ====================================================
// File: IInventoryRepository.cs
// Description: Repository interface for inventory management.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.Inventory.Queries.GetInventoryDetails;
using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Repository interface for inventory management extending the generic repository.
public interface IInventoryRepository : IGenericRepository<Inventory, Guid>
{
    Task<List<InventoryDetailDto>> GetAllInventory();
}
