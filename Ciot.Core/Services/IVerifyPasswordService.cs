namespace Ciot.Core.Services;

public interface IVerifyPassword
{
    public Task<bool> VerifyAsync(string password, string hashedPassword);
}