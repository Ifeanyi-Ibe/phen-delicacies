using Microsoft.AspNetCore.Mvc;
using PhenDelicacies.Application.Services.Authentication;
using PhenDelicacies.Contracts.Authentication;

namespace PhenDelicacies.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
{
    private readonly IAuthenticationService _authenticationService = authenticationService;

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request) 
    {
        var response = _authenticationService.Register(request.Firstname, request.Lastname, request.Email, request.Password);
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var response = _authenticationService.Login(request.Email, request.Password);
        return Ok(response);
    }
}