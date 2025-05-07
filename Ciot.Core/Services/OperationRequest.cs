using Ciot.Core.Entities;

namespace Ciot.Core.Services;

public record OperationRequest(Operation Operation, Dictionary<string, string> Parameters)
{ 
    internal Guid Id => Operation.Id;
    internal string Name => Operation.Name;
    internal string Description => Operation.Description;
}