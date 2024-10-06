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

        services.AddScoped<IPasswordHasher<Domain.User>, PasswordHasher<Domain.User>>();
        services.AddScoped<IJwtProvider, JwtProvider>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
