namespace Ciot.Core.Entities;

public class EntityBase<T>
{
    public T Id { get; set; } = default!;
}