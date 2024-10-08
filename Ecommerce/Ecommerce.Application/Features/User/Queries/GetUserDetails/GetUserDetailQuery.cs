// ====================================================
// File: GetUserDetailQuery.cs
// Description: Represents a query for retrieving a specific user's details by ID.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetUserDetails;

public record GetUserDetailQuery(Guid Id) : IRequest<UserDetailDto>;