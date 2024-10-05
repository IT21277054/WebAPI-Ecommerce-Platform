using MediatR;

namespace Ecommerce.Application.Features.UserRoles.Queries.GetUserDetails;

public record GetUserRoleDetailQuery(int Id) : IRequest<List<UserRoleDetailDto>>;
