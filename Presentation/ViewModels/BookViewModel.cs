using System;

namespace VirtualLibrary.Presentation.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Status { get; set; }

        // Additional fields can be added depending on the requirements.
    }
}