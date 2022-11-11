using MeetupMaker.Application.Common.Interfaces.Authentication;
using MeetupMaker.Application.Common.Interfaces.Persistance;
using MeetupMaker.Domain.Entities;

namespace MeetupMaker.Application.Services.Authentication;

public class AuthService : IAuthService
{
    private readonly IUserRepo _userRepo;
    private readonly IJwtTokenGenerator _tokenGen;
    public AuthService(IJwtTokenGenerator jwtTokenGenerator, IUserRepo userRepo)
    {
        _tokenGen = jwtTokenGenerator;
        _userRepo = userRepo;
    }

    public AuthenticationResult Login(string email, string password)
    {
        //check if user exists
        if (_userRepo.GetByEmail(email) is not User user)//i did not know before that this is declaration and type pattern 
        {
            throw new Exception("User with this email does not exist");
        }
        //check if password is correct
        if (user.Password != password)
        {
            throw new Exception("Invalid Password");
        }
        //Generate token
        var token = _tokenGen.GenerateToken(user);
        return new AuthenticationResult(
            user,
            token);
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //Check if exists
        if (_userRepo.GetByEmail(email) is not null)
        {
            throw new Exception("User with this email already exists");
        }
        //Create user (generate guid)
        var user = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password };
        _userRepo.Add(user);
        //Create token
        var token = _tokenGen.GenerateToken(user);
        return new AuthenticationResult(
            user,
            token);
    }
}