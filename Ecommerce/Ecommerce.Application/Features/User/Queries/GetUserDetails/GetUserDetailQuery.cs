using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetUserDetails;

public record GetUserDetailQuery(int Id) : IRequest<UserDetailDto>;
