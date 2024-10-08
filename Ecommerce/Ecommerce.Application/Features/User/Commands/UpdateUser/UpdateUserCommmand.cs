// ====================================================
// File: UpdateUserCommand.cs
// Description: Command for updating a user with the provided data transfer object (DTO).
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.UpdateUser;

public record UpdateUserCommand(UserDto dto) : IRequest<UserDto>;
