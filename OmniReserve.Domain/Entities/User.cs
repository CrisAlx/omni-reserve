using OmniReserve.Domain.Enums;
using OmniReserve.Domain.ValueObjects;

namespace OmniReserve.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public EmailAddress Email { get; private set; } = null!;
    public string PasswordHash { get; private set; } = null!;
    public Role Role { get; private set; }

    public ICollection<Reservation> Reservations { get; private set; } = new List<Reservation>();

    private User() { }

    public User(string firstName, string lastName, EmailAddress email, string passwordHash, Role role)
    {
        if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentNullException(nameof(firstName));
        if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentNullException(nameof(lastName));
        if (string.IsNullOrEmpty(passwordHash)) throw new ArgumentNullException(nameof(passwordHash));

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email ?? throw new ArgumentNullException(nameof(email));
        PasswordHash = passwordHash;
        Role = role;
    }
}