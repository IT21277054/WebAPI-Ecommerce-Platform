// ====================================================
// File: IUserRolesRepository.cs
// Description: Repository interface for handling user roles entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Repository interface for UserRoles entities
public interface IUserRolesRepository : IGenericRepository<UserRoles, Guid>
{
}
