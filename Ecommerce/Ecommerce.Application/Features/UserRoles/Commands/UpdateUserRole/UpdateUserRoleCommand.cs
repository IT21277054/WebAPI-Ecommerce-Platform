using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.UpdateUserRole;

public record UpdateUserRoleCommand(UserRoleDto dto) : IRequest<Guid>;
