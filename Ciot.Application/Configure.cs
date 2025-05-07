using Ciot.Application.Service;
using Ciot.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Ciot.Application;

public static class Configure
{
    public static IServiceCollection UseApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IVerifyPasswordService, VerifyPasswordService>();
        services.AddScoped<IDeviceService, DeviceService>();
        services.AddScoped<IExternalClient, TelnetClient>();
        return services;
    }
}