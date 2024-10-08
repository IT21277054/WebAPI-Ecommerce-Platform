// ====================================================
// File: UserRoles.cs
// Description: Entity representing user roles in the system.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class UserRoles : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;
}
