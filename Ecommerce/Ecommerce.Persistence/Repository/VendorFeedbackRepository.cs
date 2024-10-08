// ====================================================
// File: VendorFeedbackRepository.cs
// Description: Repository for managing vendor feedback entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class VendorFeedbackRepository : GenericRepository<VendorFeedback, Guid>, IVendorFeedbackRepository
{
    public VendorFeedbackRepository(EcommerceDBContext context) : base(context)
    {
    }
}
