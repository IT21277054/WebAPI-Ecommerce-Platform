using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;

namespace Ecommerce.Persistence.Repository;

public class UserRolesRepository : GenericRepository<UserRoles>, IUserRolesRepository
{
    public UserRolesRepository(EcommerceDBContext context) : base(context)
    {
    }
}
