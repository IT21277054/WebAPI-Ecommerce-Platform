using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface ICategoryRepository : IGenericRepository<Category, int>
{
    public Task<Category> GetLastCategoryAsync();
}
