// ====================================================
// File: IJwtProvider.cs
// Description: Interface for JWT token generation.
// Author: Shamry Shiraz | IT21277054
// Date: 2024-10-07
// ====================================================

using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Persistence;

// Interface for generating JWT tokens for users.
public interface IJwtProvider
{
    string Generate(User user);
}
