// ====================================================
// File: IUserRepository.cs
// Description: Repository interface for handling user entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Repository interface for User entities
public interface IUserRepository : IGenericRepository<User, Guid>
{
    Task<User> GetByEmailAsync(string email);
    Task<User> UpdateByEmail(User entity);
    Task<User> DeleteByEmail(string email);
}