namespace Ciot.Drivers.Exceptions;

public class OperationNotFound : InvalidOperationException
{
    public OperationNotFound(Guid operationId) : base($"Operation {operationId} not found")
    {
    }
}