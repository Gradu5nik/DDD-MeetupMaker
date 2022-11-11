using MeetupMaker.Application.Common.Interfaces.Authentication;
using MeetupMaker.Application.Common.Interfaces.Serivces;
using MeetupMaker.Infrastructure.Authentication;
using MeetupMaker.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MeetupMaker.Application.Common.Interfaces.Persistance;
using MeetupMaker.Infrastructure.Persistance;

namespace MeetupMaker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddScoped<IUserRepo, UserRepo>();
        return services;
    }
}