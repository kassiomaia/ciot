using Ciot.Core.Entities;
using Ciot.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ciot.Data.Repositories;

public class DeviceRepository(AppDbContext dbContext) : IDeviceRepository
{
    public async Task<Device?> GetByIdAsync(Guid id)
    {
        var device = dbContext.Devices
            .AsNoTracking()
            .Include(d => d.Operations)
            .ThenInclude(d => d.Parameters)
            .ToListAsync()
            .Result
            .FirstOrDefault(d => d.Id == id);
        return device;
    }

    public async Task<Device[]> GetAllAsync()
    {
        return dbContext.Devices
            .AsNoTracking()
            .Include(d => d.Operations)
            .ToArray();
    }
}