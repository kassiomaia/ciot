using Ciot.Core.Entities;

namespace Ciot.Application.Comamnds;

public class ExecuteOperationCommandRequest: ICommandRequest
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Timestamp { get; } = DateTime.Now;
    
    public Guid DeviceId { get; set; }
    public Guid OperationId { get; set; }
    
    public ExecuteOperationCommandRequest(Device device, Operation operation)
    {
        DeviceId = device.Id;
        OperationId = operation.Id;
    }
}