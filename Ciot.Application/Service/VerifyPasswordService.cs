using Ciot.Core.Services;

namespace Ciot.Application.Service;

public class VerifyPasswordService: IVerifyPasswordService
{
    public Task<bool> VerifyAsync(string password, string hashedPassword)
    {
        return Task.FromResult(password == hashedPassword);
    }
}