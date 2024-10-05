using MediatR;

namespace Ecommerce.Application.Features.User.Queries.GetAllUsers;

public record GetUserQuery : IRequest<List<UserDto>>;
