using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Vendor : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;

}
