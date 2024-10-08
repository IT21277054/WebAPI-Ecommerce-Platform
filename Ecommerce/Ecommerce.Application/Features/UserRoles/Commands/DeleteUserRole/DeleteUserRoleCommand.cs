// ====================================================
// File: DeleteUserRoleCommand.cs
// Description: Represents a command for deleting a user role by its ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;

public record DeleteUserRoleCommand(Guid Id) : IRequest<Unit>;