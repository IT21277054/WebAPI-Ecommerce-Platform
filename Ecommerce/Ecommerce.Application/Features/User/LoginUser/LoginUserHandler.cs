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
        // Retrieve the user from the database by email or username
        var user = await _userRepository.GetByEmailAsync(request.request.Email);
        if (user == null)
        {
            return "error";
        }

        // Verify the password
        var result = _passwordHasher.VerifyHashedPassword(user, user.Password, request.request.Password);
        if (result == PasswordVerificationResult.Success)
        {
            string token = _jwtProvider.Generate(user);
            return token;
        } else
        {
            return "error";
        }
    }

}
