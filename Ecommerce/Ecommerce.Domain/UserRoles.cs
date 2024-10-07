using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class UserRoles : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;

}
