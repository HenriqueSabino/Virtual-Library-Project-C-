using System;

namespace VirtualLibrary.Application.DTOs
{
    public class StudentDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RegistrationNumber { get; set; }
    }
}