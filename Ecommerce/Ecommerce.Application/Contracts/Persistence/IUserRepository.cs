// ====================================================
// File: IUserRepository.cs
// Description: Repository interface for handling user entities.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence
{
    // Repository interface for User entities
    public interface IUserRepository : IGenericRepository<User, Guid>
    {
        Task<Domain.User> GetByEmailAsync(string email);
    }
}
