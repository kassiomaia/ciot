using System.Text.Json.Serialization;

namespace Ciot.Core.Entities;

public class Operation: Base<Guid>
{
    public string Name { get; init; }
    public string Description { get; init; }
    public Guid DeviceId { get; init; }
    [JsonIgnore]
    public Device Device { get; init; } = default!;
    
    public List<Parameter> Parameters { get; init; } = default!;
    
    public Operation(Guid id, string name, string description)
    : base(id)
    {
        Name = name;
        Description = description;
    }

    public Operation(Guid id, string name, string description, ICollection<Parameter> parameters)
        : this(id, name, description)
    {
        Parameters = parameters.ToList();
    }
}