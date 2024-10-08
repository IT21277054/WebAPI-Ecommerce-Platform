// ====================================================
// File: InventoryRepository.cs
// Description: Repository for managing inventory entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class InventoryRepository : GenericRepository<Inventory, Guid>, IInventoryRepository
{
    public InventoryRepository(EcommerceDBContext context) : base(context)
    {
    }
}
