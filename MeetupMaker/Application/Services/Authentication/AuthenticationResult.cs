namespace MeetupMaker.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string FistName,
    string LastName,
    string Email,
    string Password
);