using Ecommerce.Domain.Common;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : IBaseEntity
{
    Task<IReadOnlyList<T>> GetAsync();
    Task<T> GetByIdAsync(int Id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
 
}
