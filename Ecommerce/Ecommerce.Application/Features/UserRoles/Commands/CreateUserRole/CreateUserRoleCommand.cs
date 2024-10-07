using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;

public record CreateUserRoleCommand(CreateUserRoleDto dto) : IRequest<Guid>;
