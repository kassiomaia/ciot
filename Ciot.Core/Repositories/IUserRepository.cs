using Ciot.Core.Entities;

namespace Ciot.Core.Repositories;

public interface IUserRepository
{
    public Task<User?> GetByEmailAsync(string email);
}