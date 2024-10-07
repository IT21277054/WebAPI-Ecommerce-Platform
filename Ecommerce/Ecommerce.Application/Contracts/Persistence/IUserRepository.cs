using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IUserRepository : IGenericRepository<User, Guid>
{
    Task<Domain.User> GetByEmailAsync(string email);
}
