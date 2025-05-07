namespace Ciot.Core.Entities;

public class Base<T>
{
    public T Id { get; init; } = default!;
    
    protected Base(T id)
    {
        Id = id;
    }
}