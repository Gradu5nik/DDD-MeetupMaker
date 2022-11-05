using MeetupMaker.Application.Common.Interfaces.Authentication;

namespace MeetupMaker.Application.Services.Authentication;

public class AuthService : IAuthService
{
    private readonly IJwtTokenGenerator _tokenGen;
    public AuthService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _tokenGen = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstname",
            "lastname",
            email,
            "token");
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //Check if exists
        //Create user (generate guid)
        Guid userId = Guid.NewGuid();
        //Create token
        var token = _tokenGen.GenerateToken(userId, firstName, lastName);
        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token);
    }
}