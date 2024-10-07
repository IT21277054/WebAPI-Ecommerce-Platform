using MediatR;

namespace Ecommerce.Application.Features.User.Commands.DeleteUser;

public record DeleteUserCommand(Guid Id) : IRequest<Unit>;