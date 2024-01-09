using System;

namespace VirtualLibrary.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }

    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}