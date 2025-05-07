using Ciot.Core.Entities;
using Ciot.Core.Repositories;
using Ciot.Core.Types;

namespace Ciot.Core.Services;

public class AuthService(IUserRepository userRepository, IVerifyPasswordService verifyPasswordService) : IAuthService
{
    public async Task<Result<User, string>> AuthenticateAsync(string email, string password)
    {
        var user = userRepository.GetByEmailAsync(email).Result;
        if (user == null)
            return Result<User, string>.Fail("The user could not be found, please check the email");

        var isValid = await verifyPasswordService.VerifyAsync(user.Password, password);
        return isValid
            ? Result<User, string>.Ok(user)
            : Result<User, string>.Fail("The password is incorrect, please try again");
    }
}