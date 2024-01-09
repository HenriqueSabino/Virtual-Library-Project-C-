using System;

namespace Core.Entities
{
    public class Administrator
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }
        public string Email { get; private set; }
        public string FullName { get; private set; }

        public Administrator(Guid id, string username, string passwordHash, string email, string fullName)
        {
            Id = id;
            Username = username ?? throw new ArgumentNullException(nameof(username));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        }

        // Methods for domain behaviors such as password change can be added here
    }
}