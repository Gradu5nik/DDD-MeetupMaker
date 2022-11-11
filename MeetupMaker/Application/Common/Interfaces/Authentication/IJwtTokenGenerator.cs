using MeetupMaker.Domain.Entities;

namespace MeetupMaker.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}