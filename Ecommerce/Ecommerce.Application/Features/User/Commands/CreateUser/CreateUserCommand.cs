using Ecommerce.Application.Features.User.Commands.CreateUser;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateUserCommand(CreateUserDto dto) : IRequest<Guid>;