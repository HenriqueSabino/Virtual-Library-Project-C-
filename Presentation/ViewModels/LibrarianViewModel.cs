using System;

namespace Presentation.ViewModels
{
    public class LibrarianViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        // Add any other properties that should be displayed for a librarian in the presentation layer.
    }
}
```
