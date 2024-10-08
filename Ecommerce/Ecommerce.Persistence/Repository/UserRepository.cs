// ====================================================
// File: UserRepository.cs
// Description: Repository for managing user entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

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
        _context = context; // Initialize the database context
    }

    // Retrieve a user by their email address (case-insensitive)
    public async Task<User> GetByEmailAsync(string email)
    {
        return await _context.User.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower()); // Find user by email
    }
}
