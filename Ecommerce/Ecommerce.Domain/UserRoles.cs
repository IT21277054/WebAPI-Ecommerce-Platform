using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class UserRoles : IBaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;

}
