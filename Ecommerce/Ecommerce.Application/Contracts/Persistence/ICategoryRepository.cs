// ====================================================
// File: ICategoryRepository.cs
// Description: Interface for Category repository operations.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence
{
    // ICategoryRepository extends the generic repository interface for Category entities.
    public interface ICategoryRepository : IGenericRepository<Category, int>
    {
        // Retrieves the last added category asynchronously.
        Task<Category> GetLastCategoryAsync();
    }
}
