// ====================================================
// File: IVendorRepository.cs
// Description: Repository interface for handling vendor entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Repository interface for Vendor entities
public interface IVendorRepository : IGenericRepository<Vendor, Guid>
{
}
