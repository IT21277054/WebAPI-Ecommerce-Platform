// ====================================================
// File: UpdateUserRoleCommand.cs
// Description: Represents a command for updating a user role.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.UpdateUserRole;

public record UpdateUserRoleCommand(UserRoleDto dto) : IRequest<Guid>;