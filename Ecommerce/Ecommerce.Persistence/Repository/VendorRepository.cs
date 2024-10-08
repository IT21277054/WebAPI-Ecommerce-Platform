// ====================================================
// File: VendorRepository.cs
// Description: Repository for managing vendor entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class VendorRepository : GenericRepository<Vendor, Guid>, IVendorRepository
{
    public VendorRepository(EcommerceDBContext context) : base(context)
    {
    }
}
