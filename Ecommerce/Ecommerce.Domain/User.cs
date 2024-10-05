using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class User : IBaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public UserRoles? UserRole { get; set; }

}
