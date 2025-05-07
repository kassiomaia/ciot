namespace Ciot.Drivers.Devices;

public record Operation(Guid Id, string Name, string Description, Func<object?> Action)
{
    
}