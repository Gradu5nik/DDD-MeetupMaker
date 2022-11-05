namespace MeetupMaker.Application.Common.Interfaces.Serivces;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}