// ====================================================
// File: IUserRolesRepository.cs
// Description: Repository interface for handling user roles entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Repository interface for Vendor Feedback entities
public interface IVendorFeedbackRepository : IGenericRepository<VendorFeedback, Guid>
{
    Task<List<VendorFeedback>> GetVendorFeedbackByVendorId(Guid vendorId);
}
