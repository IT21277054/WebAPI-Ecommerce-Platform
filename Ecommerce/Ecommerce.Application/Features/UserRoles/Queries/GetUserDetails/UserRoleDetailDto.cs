// ====================================================
// File: UserRoleDetailDto.cs
// Description: Represents the data transfer object (DTO) for user role details.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;

public class UserRoleDetailDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ValueCode { get; set; } = string.Empty;
}