// ====================================================
// File: LoginUserCommand.cs
// Description: Represents a command for logging in a user.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using MediatR;

namespace Ecommerce.Application.Features.User.LoginUser;

public record LoginUserCommand(LoginUserDto request) : IRequest<string>;