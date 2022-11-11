using MeetupMaker.Application.Services.Authentication;
using MeetupMaker.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace MeetupMaker.API.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthenticationController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
        //Convert result to Register Response from contracts
        var response = new RegisterResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
        );
        return Ok(response);
    }
    [HttpPost("Login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authService.Login(
            request.Email,
            request.Password
        );
        var response = new RegisterResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
        );
        return Ok(response);
    }
}