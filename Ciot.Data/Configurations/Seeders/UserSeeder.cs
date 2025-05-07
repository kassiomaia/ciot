using Ciot.Core.Entities;

namespace Ciot.Data.Seeds;

internal static class UserSeeder
{
    public static IReadOnlyCollection<User> All()
    {
        var users = new List<User>
        {
            new(
                Guid.NewGuid(),
                "John Doe",
                "johndoe@ciot.io",
                "admin"
            ),
            new(
                Guid.NewGuid(),
                "Jane Smith",
                "janesmith@ciot.io",
                "admin"
            ),
            new(
                Guid.NewGuid(),
                "Afonso Ribeiro",
                "afonsoribeiro@ciot.io",
                "admin"
            ),
            new(
                Guid.NewGuid(),
                "Maria Garcia",
                "maria@ciot.io",
                "admin"
            ),
            new(
                Guid.NewGuid(),
                "José Silva",
                "jose@ciot.io",
                "admin"
            ),
        };

        return users.AsReadOnly();
    }
}