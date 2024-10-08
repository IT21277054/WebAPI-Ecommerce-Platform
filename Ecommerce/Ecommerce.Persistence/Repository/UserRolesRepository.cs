// ====================================================
// File: UserRolesRepository.cs
// Description: Repository for managing user roles entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class UserRolesRepository : GenericRepository<UserRoles, Guid>, IUserRolesRepository
{
    public UserRolesRepository(EcommerceDBContext context) : base(context)
    {
    }
}
