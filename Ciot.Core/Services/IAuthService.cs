using Ciot.Core.Entities;

namespace Ciot.Core.Services;

public interface IAuthenticationService
{
    public Task<User?> AuthenticateAsync(string email, string password);
}