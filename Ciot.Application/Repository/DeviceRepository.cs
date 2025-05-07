using Ciot.Core.Entities;
using Ciot.Core.Repositories;
using Ciot.Service.Builders;

namespace Ciot.Service.Repository;

public class DeviceRepository : IDeviceRepository
{
    private readonly IReadOnlyCollection<Device> _devices = DeviceStaticCollection.Build();

    public Task<Device?> Get(Guid id)
    {
        return Task.FromResult(_devices.FirstOrDefault(x => x.Id == id));
    }

    public Task<IReadOnlyCollection<Device>> GetAll()
    {
        return Task.FromResult(_devices);
    }
}