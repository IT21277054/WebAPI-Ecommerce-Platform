using MediatR;

namespace Ecommerce.Application.Features.User.LoginUser;

public record LoginUserCommand(LoginUserDto request) : IRequest<string>;
