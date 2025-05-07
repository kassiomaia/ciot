namespace Ciot.Core.Services;

public interface IVerifyPasswordService
{
    public Task<bool> VerifyAsync(string password, string hashedPassword);
}