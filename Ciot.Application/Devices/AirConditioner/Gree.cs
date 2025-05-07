using Ciot.Core.Entities;

namespace Ciot.Application.Devices.AirConditioner;

public class Rheem: Device
{
    public Rheem() : base(Guid.NewGuid(), "Rheem", "Rheem - Air Conditioner High Efficiency")
    {
    }
}