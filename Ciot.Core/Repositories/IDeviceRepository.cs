using Ciot.Core.Entities;

namespace Ciot.Core.Repositories;

public interface IDeviceRepository
{
    public Task<Device?> GetByIdAsync(Guid id);
    public Task<Device[]> GetAllAsync();
}