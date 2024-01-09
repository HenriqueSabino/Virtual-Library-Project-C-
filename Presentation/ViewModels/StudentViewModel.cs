using System;

namespace VirtualLibrary.Presentation.ViewModels
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AcademicStatus { get; set; }
        // Additional fields may include rental history, student ID, etc.
    }
}