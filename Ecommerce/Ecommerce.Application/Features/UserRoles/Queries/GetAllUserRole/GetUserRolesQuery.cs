// ====================================================
// File: GetUserRolesQuery.cs
// Description: Represents a query for retrieving all user roles.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;

public record GetUserRolesQuery : IRequest<List<UserRoleDto>>;