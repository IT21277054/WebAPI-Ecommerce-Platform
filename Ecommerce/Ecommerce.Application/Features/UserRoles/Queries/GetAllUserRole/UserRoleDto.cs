// ====================================================
// File: UserRoleDto.cs
// Description: Represents the data transfer object (DTO) for a user role.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;

public class UserRoleDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;
}