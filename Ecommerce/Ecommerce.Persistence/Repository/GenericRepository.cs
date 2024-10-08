// ====================================================
// File: GenericRepository.cs
// Description: Generic repository for managing CRUD operations on entities.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain.Common;
using Ecommerce.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence.Repository;

public class GenericRepository<T, Y> : IGenericRepository<T, Y> where T : BaseEntity<Y> where Y : struct
{
    protected EcommerceDBContext _context;

    public GenericRepository(EcommerceDBContext context)
    {
        this._context = context; // Initialize the database context
    }

    // Create a new entity
    public async Task CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync(); // Save changes to the database
    }

    // Delete an existing entity
    public async Task DeleteAsync(T entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync(); // Save changes to the database
    }

    // Retrieve all entities
    public async Task<IReadOnlyList<T>> GetAsync()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync(); // Return entities without tracking
    }

    // Retrieve an entity by its ID
    public async Task<T> GetByIdAsync(Y Id)
    {
        return await _context.Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(q => q.Id.Equals(Id)); // Return the entity with the specified ID
    }

    // Update an existing entity
    public async Task UpdateAsync(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync(); // Save changes to the database
    }
}
