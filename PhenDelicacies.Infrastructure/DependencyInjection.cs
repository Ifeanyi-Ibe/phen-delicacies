
using Microsoft.Extensions.Configuration;
using PhenDelicacies.Application.Common.Interfaces;
using PhenDelicacies.Infrastructure.Authentication;
using PhenDelicacies.Infrastructure.Services;
using PhenDelicacies.Infrastructure.Persistence;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}