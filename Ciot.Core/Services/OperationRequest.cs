using Ciot.Core.Entities;

namespace Ciot.Core.Services;

public record OperationRequest(Operation Operation)
{
    
    public static OperationRequest Of(Operation operation)
    {
        return new OperationRequest(operation);
    }

    internal Guid Id => Operation.Id;
    internal string Name => Operation.Name;
    internal string Description => Operation.Description;
}