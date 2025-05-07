using Ciot.Core.Entities;
using Ciot.Core.Repositories;

namespace Ciot.Data.Repositories;

public class UserRepository: IUserRepository
{
    
    private readonly AppDbContext _appDbContext;
    
    public UserRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public Task<User?> GetByEmailAsync(string email)
    {
        var user = _appDbContext.Users
            .FirstOrDefault(u => u.Email == email);

        return Task.FromResult(user);
    }
}