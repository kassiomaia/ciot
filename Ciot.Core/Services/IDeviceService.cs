namespace Ciot.Core.Services;

public interface IDeviceService
{
    public Task<bool> ExecuteAsync(OperationRequest request);
}