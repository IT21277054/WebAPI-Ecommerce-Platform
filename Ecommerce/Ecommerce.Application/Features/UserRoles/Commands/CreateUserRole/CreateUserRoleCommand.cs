using Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;
using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Commands.CreateUserRole;

public record CreateUserRoleCommand(CreateUserRoleDto dto) : IRequest<Guid>;
