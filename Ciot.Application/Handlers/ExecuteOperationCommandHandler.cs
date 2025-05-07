using Ciot.Application.Comamnds;

namespace Ciot.Application.Handlers;

public class ExecuteOperationAsyncHandler: IAsyncHandler<ExecuteOperationCommand>
{
    public Task<IAsyncResult> HandlerAsync(ExecuteOperationCommand command)
    {
        throw new NotImplementedException();
    }
}