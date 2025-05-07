using Ciot.Core.Entities;
using Ciot.Core.Repositories;
using Ciot.Data.Configurations.Seeders;
using Ciot.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ciot.Data;

public static class Configure
{
    public static void UseInMemoryDatabase(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("InMemoryDb"));

        services.AddScoped<IDeviceRepository, DeviceRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        
        /*
         * Populate the in-memory database with initial data.         
         */
        
        using var scope = services.BuildServiceProvider().CreateScope();
    
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.EnsureDeleted();
        dbContext.Devices.AddRange(DeviceSeeder.All());
        dbContext.Users.AddRange(UserSeeder.All());
        dbContext.SaveChanges();
    }
}