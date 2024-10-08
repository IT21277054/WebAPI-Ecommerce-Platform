// ====================================================
// File: CreateUserRoleDto.cs
// Description: Represents the data transfer object (DTO) for creating a new user role.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;

public class CreateUserRoleDto
{
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;
}