using System;

namespace Core.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public BookStatus Status { get; set; }
    }

    public enum BookStatus
    {
        Available,
        Rented,
        Reserved,
        UnderMaintenance
    }
}