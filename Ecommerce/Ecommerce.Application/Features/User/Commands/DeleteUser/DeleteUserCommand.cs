using MediatR;

namespace Ecommerce.Application.Features.User.Commands.DeleteUser;

public record DeleteUserCommand(int Id) : IRequest<Unit>;