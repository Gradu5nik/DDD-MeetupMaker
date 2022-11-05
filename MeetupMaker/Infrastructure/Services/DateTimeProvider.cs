using MeetupMaker.Application.Common.Interfaces.Serivces;

namespace MeetupMaker.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}