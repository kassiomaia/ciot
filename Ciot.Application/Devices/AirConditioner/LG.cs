using Ciot.Core.Entities;

namespace Ciot.Application.Devices.AirConditioner;

public class Gree: Device
{
    public Gree() : base(Guid.NewGuid(), "Gree", "Gree - Air Conditioner High Efficiency")
    {
    }
}