using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IUserRepository : IGenericRepository<User>
{
    Task<Domain.User> GetByEmailAsync(string email);
}
