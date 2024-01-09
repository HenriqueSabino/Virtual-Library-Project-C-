using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public List<Rental> RentalHistory { get; set; }

        public Student()
        {
            RentalHistory = new List<Rental>();
        }

        // Additional student-related methods can be added here
    }

    public class Rental
    {
        public Book Book { get; set; }
        public DateTime RentedOn { get; set; }
        public DateTime? ReturnedOn { get; set; }
        
        // Additional rental-related methods can be added here
    }
}