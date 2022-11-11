namespace MeetupMaker.Application.Services.Authentication;

public interface IAuthService
{
    AuthenticationResult Login(string Email, string Password);
    AuthenticationResult Register(string FistName, string LastName, string Email, string Password);
}