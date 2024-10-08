// ====================================================
// File: CreateUserRoleCommand.cs
// Description: Represents a command for creating a new user role.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;

public record CreateUserRoleCommand(CreateUserRoleDto dto) : IRequest<Guid>;