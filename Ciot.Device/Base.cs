using Ciot.Device.Exceptions;

namespace Ciot.Device;

public abstract class Device
{
    private readonly List<Operation> _operations = new();
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IReadOnlyList<Operation> Operations => _operations;

    protected Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    protected void AddOperation(Operation operation)
    {
        _operations.Add(operation);
    }
    
    public Task<object?> Handle(Guid operationId)
    {
        var operation = Operations.FirstOrDefault(x => x.Id == operationId);
        if (operation == null)
            throw new OperationNotFound(operationId);
        
        return Task.FromResult(operation.Action());
    }
}