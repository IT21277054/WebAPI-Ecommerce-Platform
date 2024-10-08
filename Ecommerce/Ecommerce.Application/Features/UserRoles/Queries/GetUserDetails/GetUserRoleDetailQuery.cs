// ====================================================
// File: GetUserRoleDetailQuery.cs
// Description: Represents a query for retrieving a specific user role's details by ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;

public record GetUserRoleDetailQuery(Guid Id) : IRequest<UserRoleDetailDto>;