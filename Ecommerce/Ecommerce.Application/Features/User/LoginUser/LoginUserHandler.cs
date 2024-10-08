// ====================================================
// File: LoginUserHandler.cs
// Description: Handler for the LoginUserCommand. Authenticates a user and returns a JWT token if successful.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Application.Features.User.LoginUser;

public class LoginUserHandler : IRequestHandler<LoginUserCommand, string>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<Domain.User> _passwordHasher;
    private readonly IJwtProvider _jwtProvider;

    public LoginUserHandler(IUserRepository userRepository, IPasswordHasher<Domain.User> passwordHasher, IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _jwtProvider = jwtProvider;
    }

    public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        // Find user by email
        var user = await _userRepository.GetByEmailAsync(request.request.Email);
        if (user == null)
        {
            return "error";  // User not found
        }

        // Verify password
        var result = _passwordHasher.VerifyHashedPassword(user, user.Password, request.request.Password);
        if (result == PasswordVerificationResult.Success)
        {
            // Generate JWT on successful login
            return _jwtProvider.Generate(user);
        }
        else
        {
            return "error";  // Invalid password
        }
    }
}