using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.UpdateUser;

public record UpdateUserCommmand(UserDto dto) : IRequest<int>;
