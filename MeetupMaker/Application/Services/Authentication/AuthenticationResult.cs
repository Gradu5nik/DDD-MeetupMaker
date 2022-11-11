using MeetupMaker.Domain.Entities;

namespace MeetupMaker.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);