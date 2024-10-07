using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IJwtProvider
{
    string Generate(User user);
}
