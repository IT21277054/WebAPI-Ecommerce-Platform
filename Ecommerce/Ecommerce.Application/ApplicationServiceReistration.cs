// ====================================================
// File: ApplicationServiceReistration.cs
// Description: Service registration for application services in the dependency injection container.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Ecommerce.Application.Contracts.Persistence;
using Ecommerce.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ecommerce.Application;

public static class ApplicationServiceReistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register PasswordHasher for User entity
        services.AddScoped<IPasswordHasher<Domain.User>, PasswordHasher<Domain.User>>();

        // Register JwtProvider for JWT token generation
        services.AddScoped<IJwtProvider, JwtProvider>();

        // Register AutoMapper for object mapping
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        // Register MediatR for handling requests and notifications
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services; // Return the updated services collection
    }
}
