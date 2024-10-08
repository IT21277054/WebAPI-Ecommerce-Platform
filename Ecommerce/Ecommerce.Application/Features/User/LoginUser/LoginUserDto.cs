// ====================================================
// File: LoginUserHandler.cs
// Description: Handler for the LoginUserCommand. Authenticates a user and returns a JWT token if successful.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

namespace Ecommerce.Application.Features.User.LoginUser;

public class LoginUserDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}