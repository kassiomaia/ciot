using Ciot.Core.Services;

namespace Ciot.Application.Service;

public class TelnetClient : IExternalClient
{
    public async Task<string> Run(string command)
    {
        Console.WriteLine($"Running command: {command}");
        Task.Delay(2500).Wait();
        return "Command executed successfully";
    }

    public string ParseArgs(OperationRequest request)
    {
        var parameters = request.Parameters.Select(p => $"echo \"Parameter {p.Key}\"; echo \"ParameterValue {p.Value}\"");
        var args = string.Join(" ", parameters);
        var command = $"{{ echo \"DeviceId {request.Operation.DeviceId}\"; echo \"OperationId {request.Operation.Id}\"; {args} }} | telnet 127.0.0.1 23";
        return command;
    }
}