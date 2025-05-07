namespace Ciot.Core.Entities;

public class User : Base<Guid>
{
    public string Name { get; init; } = default!;
    public string Email { get; init; } = default!;
    public string Password { get; init; } = default!;

    public User(Guid id, string name, string email, string password)
        : base(id)
    {
        Name = name;
        Email = email;
        Password = password;
    }
}