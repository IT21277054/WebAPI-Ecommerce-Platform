// ====================================================
// File: CreateUserCommand.cs
// Description: Command for creating a user with the provided data transfer object (DTO).
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Application.Features.User.Commands.CreateUser;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateUserCommand(CreateUserDto dto) : IRequest<Guid>;
