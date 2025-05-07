namespace Ciot.Core.Entities;

public class Device : Base<Guid>
{
    public string Name { get; init; } = default!;
    public string Description { get; init; } = default!;
    public string Type { get; init; } = default!;
    public string Manufacturer { get; init; } = default!;
    public string Model { get; init; } = default!;
    public string SerialNumber { get; init; } = default!;

    public List<Operation> Operations { get; init; } = default!;

    public Device(string name, string description, string type, string manufacturer, string model, string serialNumber)
        : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        Type = type;
        Manufacturer = manufacturer;
        Model = model;
        SerialNumber = serialNumber;
    }

    public Device(Guid id, string name, string description, string type, string manufacturer, string model,
        string serialNumber, ICollection<Operation> operations)
        : base(id)
    {
        Name = name;
        Description = description;
        Type = type;
        Manufacturer = manufacturer;
        Model = model;
        SerialNumber = serialNumber;
        Operations = operations.ToList();
    }

    public void AddOperation(Operation operation)
    {
        ArgumentNullException.ThrowIfNull(operation);

        if (Operations.Any(x => x.Id == operation.Id))
            throw new InvalidOperationException($"Operation with id {operation.Id} already exists.");

        Operations.Add(operation);
    }

    public bool HasOperation(Guid operationId)
    {
        return Operations.Any(x => x.Id == operationId);
    }

    public Operation? GetOperation(Guid operationId)
    {
        return Operations.FirstOrDefault(x => x.Id == operationId);
    }
}