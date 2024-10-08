using Ecommerce.Application.Features.User.Queries.GetAllUsers;
using MediatR;

namespace Ecommerce.Application.Features.User.Commands.DeleteUser;

public record DeleteUserCommand(string email) : IRequest<UserDto>;