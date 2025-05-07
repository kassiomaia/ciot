namespace Ciot.Application.Comamnds;

public interface ICommand
{
    public Guid Id { get; }
    public DateTime Timestamp { get; }
}