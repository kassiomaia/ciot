using Ciot.Core.Entities;
using Ciot.Core.Repositories;
using Ciot.Data.Repositories;
using Ciot.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ciot.Data;

public static class ConfigureInMemoryDatabase
{
    public static void UseInMemoryDatabase(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContent>(options =>
            options.UseInMemoryDatabase("InMemoryDb"));

        services.AddScoped<IDeviceRepository, DeviceRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }

    public static void UseStaticData(this IServiceCollection services)
    {
        using var scope = services.BuildServiceProvider().CreateScope();

        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContent>();
        
        dbContext.Database.EnsureDeleted();
        dbContext.Devices.AddRange(DeviceSeeder.All());
        dbContext.Users.AddRange(UserSeeder.All());
        dbContext.SaveChanges();
    }
}