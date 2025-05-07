using Ciot.Core.Entities;
using Ciot.Core.Types;

namespace Ciot.Core.Services;

public interface IAuthService
{
    public Task<Result<User, string>> AuthenticateAsync(string email, string password);
}