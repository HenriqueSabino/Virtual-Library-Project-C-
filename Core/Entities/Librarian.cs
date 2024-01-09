using System;

namespace Core.Entities
{
    public class Librarian
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // Assuming a hashed password, not plain text for security
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        
        // Additional fields and methods related to the librarian's role and responsibilities
        // could be added here, depending on the specific business logic and use cases of the system.
    }
}