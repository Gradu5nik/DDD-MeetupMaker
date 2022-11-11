using MeetupMaker.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace MeetupMaker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }
}