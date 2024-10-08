// ====================================================
// File: CartRepository.cs
// Description: Repository for managing cart entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

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
