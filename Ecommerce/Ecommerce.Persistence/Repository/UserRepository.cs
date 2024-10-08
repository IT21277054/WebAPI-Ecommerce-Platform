// ====================================================
// File: UserRepository.cs
// Description: Repository for managing user entities in the database.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using User = Ecommerce.Domain.User;

namespace Ecommerce.Persistence.Repository;

public class UserRepository : GenericRepository<User, Guid>, IUserRepository
{
    private readonly EcommerceDBContext _context;
    private readonly IPasswordHasher<Domain.User> _passwordHasher;

    public UserRepository(EcommerceDBContext context, IPasswordHasher<User> passwordHasher) : base(context)
    {
        _context = context; // Initialize the database context
        _passwordHasher = passwordHasher;
    }

    // Retrieve a user by their email address (case-insensitive)
    public async Task<User> GetByEmailAsync(string email)
    {
        return await _context.User.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower()); // Find user by email
    }

    public async Task<User> DeleteByEmail(string email)
    {
        // Find the user by email
        var user = await _context.User.FirstOrDefaultAsync(u => u.Email == email);

        if (user == null)
        {
            // Handle the case where the user is not found
            throw new Exception("User not found.");
        }

        // Remove the user from the context
        _context.User.Remove(user);

        // Save changes to the database
        await _context.SaveChangesAsync();

        // Return the deleted user entity or handle accordingly
        return user;
    }


    public async Task<User> UpdateByEmail(User entity)
    {
        // Find the user by email
        var existingUser = await _context.User.FirstOrDefaultAsync(u => u.Email.ToLower() == entity.Email.ToLower());

        if (existingUser == null)
        {
            // Handle the case where the user is not found
            throw new ArgumentException("User with the given email not found.");
        }

        // Update the properties only if they are not default (non-empty for strings, non-default for bool)
        if (!string.IsNullOrEmpty(entity.Name))
        {
            existingUser.Name = entity.Name;
        }

        if (!string.IsNullOrEmpty(entity.MobileNumber))
        {
            existingUser.MobileNumber = entity.MobileNumber;
        }

        if (!string.IsNullOrEmpty(entity.Address))
        {
            existingUser.Address = entity.Address;
        }

        if (!string.IsNullOrEmpty(entity.City))
        {
            existingUser.City = entity.City;
        }

        if (!string.IsNullOrEmpty(entity.Region))
        {
            existingUser.Region = entity.Region;
        }
        if (!string.IsNullOrEmpty(entity.Password))
        {
            existingUser.Password = _passwordHasher.HashPassword(entity, entity.Password);
            existingUser.Password = entity.Password;
        }

        if (!string.IsNullOrEmpty(entity.UserRole))
        {
            existingUser.UserRole = entity.UserRole;
        }

        // Update isActivated only if its value is different
        if (existingUser.isActivated != entity.isActivated)
        {
            existingUser.isActivated = entity.isActivated;
        }

        // Save the updated entity
        _context.User.Update(existingUser);
        await _context.SaveChangesAsync();

        return existingUser;
    }

}
