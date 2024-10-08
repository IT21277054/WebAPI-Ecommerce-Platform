// ====================================================
// File: InfrastructureServicesRegistration.cs
// Description: Service registration for infrastructure-related services.
// Author: Shamry Shiraz | IT21227704
// Date: 2024-10-08
// ====================================================

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services; // Return the updated services collection
    }
}
