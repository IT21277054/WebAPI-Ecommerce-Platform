// ====================================================
// File: IGenericRepository.cs
// Description: Generic repository interface for CRUD operations.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Application.Contracts.Persistence;

// Generic repository interface for CRUD operations on entities derived from BaseEntity.
public interface IGenericRepository<T, Y> where T : BaseEntity<Y>
{
    // Retrieve all entities asynchronously.
    Task<IReadOnlyList<T>> GetAsync();

    // Retrieve an entity by its ID asynchronously.
    Task<T> GetByIdAsync(Y Id);

    // Create a new entity asynchronously.
    Task CreateAsync(T entity);

    // Update an existing entity asynchronously.
    Task UpdateAsync(T entity);

    // Delete an existing entity asynchronously.
    Task DeleteAsync(T entity);
}
