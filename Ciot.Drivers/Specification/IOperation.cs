namespace Ciot.Device.Specification;

public interface IOperation
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
}