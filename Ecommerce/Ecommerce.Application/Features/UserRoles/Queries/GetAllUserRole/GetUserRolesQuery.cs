using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetAllUserRole;

public record GetUserRolesQuery : IRequest<List<UserRoleDto>>;
