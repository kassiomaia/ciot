using System.Text.Json.Serialization;

namespace Ciot.Core.Entities;

public class Parameter : Base<Guid>
{
    public string Name { get; set; }
    public string Value { get; set; }
    public ParameterType Type { get; set; }
    public Guid OperationId { get; set; }
    [JsonIgnore]
    public Operation Operation { get; set; }

    public Parameter(Guid id, string name, string value, ParameterType type) : base(id)
    {
        Name = name;
        Value = value;
        Type = type;
    }
}