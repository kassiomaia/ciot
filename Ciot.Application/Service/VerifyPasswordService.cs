using Ciot.Core.Services;

namespace Ciot.Application.Service;

public class VerifyPasswordServiceService: IVerifyPasswordService
{
    public Task<bool> VerifyAsync(string password, string hashedPassword)
    {
        return Task.FromResult(password == hashedPassword);
    }
}