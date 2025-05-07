using Ciot.Service;

namespace Ciot;

class Program
{
    public void Main()
    {
        DeviceBuilder builder = new DeviceBuilder();

        List<Device> devices =
        [
            builder.WithAutoID().WithName("IOT Device 1").WithDescription("IOT Device 1")
                .WithOperations([
                    new Operation(Guid.NewGuid(), "Operation 1", "Operation 1"),
                    new Operation(Guid.NewGuid(), "Operation 2", "Operation 2"),
                    new Operation(Guid.NewGuid(), "Operation 3", "Operation 3")
                ])
                .Build(),
            builder.WithAutoID().WithName("IOT Device 2")
                .WithDescription("IOT Device 2")
                .WithOperations([
                    new Operation(Guid.NewGuid(), "Operation 2", "Operation 2"),
                    new Operation(Guid.NewGuid(), "Operation 3", "Operation 3")
                ])
                .Build(),
        ];
    }
}