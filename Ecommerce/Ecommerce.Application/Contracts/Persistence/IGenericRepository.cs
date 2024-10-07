using Ecommerce.Domain.Common;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IGenericRepository<T,Y> where T : BaseEntity<Y>
{
    Task<IReadOnlyList<T>> GetAsync();
    Task<T> GetByIdAsync(Y Id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
