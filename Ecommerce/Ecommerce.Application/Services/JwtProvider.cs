// ====================================================
// File: JwtProvider.cs
// Description: Service for generating JWT tokens for users.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

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
        // Create claims based on the user information
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Name, user.Name),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("mobileNumber", user.MobileNumber),
            new Claim("role", user.UserRole),
            new Claim("address", user.Address)
        };

        // Define the signing credentials using a symmetric security key
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("my-very-secure-secret-key-21277054-SY-S1")),
            SecurityAlgorithms.HmacSha256);

        // Create the JWT security token
        var token = new JwtSecurityToken(
            "issueer",
            "audience",
            claims,
            null,
            DateTime.UtcNow.AddHours(1),
            signingCredentials);

        // Write the token to a string
        string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue; // Return the generated token
    }
}
