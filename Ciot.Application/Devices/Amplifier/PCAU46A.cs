using Ciot.Core.Entities;

namespace Ciot.Application.Devices;

public class PylePcau46A : Core.Entities.Device
{
    public PylePcau46A()
        : base(Guid.NewGuid(), "Amplifier", "Amplifier description")
    {
    }
}