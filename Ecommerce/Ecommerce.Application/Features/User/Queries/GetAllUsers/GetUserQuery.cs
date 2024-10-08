// ====================================================
// File: GetUserQuery.cs
// Description: Represents a query for retrieving all users.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetAllUsers;

public record GetUserQuery : IRequest<List<UserDto>>;