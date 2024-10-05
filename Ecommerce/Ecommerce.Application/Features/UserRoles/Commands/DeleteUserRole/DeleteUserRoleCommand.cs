using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;

public record DeleteUserRoleCommand(int Id) : IRequest<Unit>;
