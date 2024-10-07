using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetUserDetails;

public record GetUserDetailQuery(Guid Id) : IRequest<UserDetailDto>;
