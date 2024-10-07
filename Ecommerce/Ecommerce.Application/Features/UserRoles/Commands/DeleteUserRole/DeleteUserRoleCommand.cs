using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.DeleteUserRole;

public record DeleteUserRoleCommand(Guid Id) : IRequest<Unit>;
