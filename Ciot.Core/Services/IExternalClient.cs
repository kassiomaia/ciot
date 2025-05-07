namespace Ciot.Core.Services;

public interface IExternalClient
{
    Task<string> Run(string command);
    string ParseArgs(OperationRequest request);
}