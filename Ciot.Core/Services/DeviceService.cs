namespace Ciot.Core.Services;

public class DeviceService(IExternalClient client) : IDeviceService
{
    public async Task<bool> ExecuteAsync(OperationRequest request)
    {
        var command = client.ParseArgs(request);
        if (string.IsNullOrEmpty(command))
        {
            return false;
        }
        
        await client.Run(command);

        return true;
    }
}