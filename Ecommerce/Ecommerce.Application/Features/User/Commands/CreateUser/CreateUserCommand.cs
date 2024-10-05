using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;

namespace Ecommerce.Application.Features.OrderCancellation.Commands.CreateOrderCancellation;

public record CreateUserCommand(UserDto dto) : IRequest<int>;