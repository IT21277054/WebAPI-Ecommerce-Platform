using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class UserRepository : GenericRepository<User, Guid>, IUserRepository
{
    private readonly EcommerceDBContext _context;

    public UserRepository(EcommerceDBContext context) : base(context)
    {
        _context = context;
    }

    public async Task<User> GetByEmailAsync(string email)
    {
        return await _context.User.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
    }
}
