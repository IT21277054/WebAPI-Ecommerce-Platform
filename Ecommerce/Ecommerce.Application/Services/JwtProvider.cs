using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Ecommerce.Application.Services;

public sealed class JwtProvider : IJwtProvider
{
    public string Generate(User user)
    {
        var claims = new Claim[] { };

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("my-very-secure-secret-key-21277054-SY-S1")),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
        "issueer",
        "audience",
        claims,
        null,
        DateTime.UtcNow.AddHours(1),
        signingCredentials);

        string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }
}
