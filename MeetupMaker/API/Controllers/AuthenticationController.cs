using MeetupMaker.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace MeetupMaker.API.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }
    [HttpPost("Login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}