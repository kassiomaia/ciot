using Ciot.Application.Comamnds;

namespace Ciot.Application.Handlers;

public interface IAsyncHandler<in T> where T : ICommand
{
    public Task<IAsyncResult> Handle(T command);
}