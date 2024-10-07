using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;

public record GetUserRoleDetailQuery(Guid Id) : IRequest<UserRoleDetailDto>;
