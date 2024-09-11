using PhenDelicacies.Application.Common.Interfaces;
using PhenDelicacies.Application.Services.Authentication.Dtos;

namespace PhenDelicacies.Application.Services.Authentication;

public class AuthenticationService(IJwtTokenGenerator tokenGenerator) : IAuthenticationService
{
    private readonly IJwtTokenGenerator _tokenGenerator = tokenGenerator;

    public AuthenticationResponse Login(string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), "Ken", "Simon", "ken@gmail.com", "skjrfkjaksj32je");
    }

    public AuthenticationResponse Register(string firstname, string lastname, string email, string password)
    {
        var token = _tokenGenerator.GenerateToken(Guid.NewGuid(), firstname, lastname);
        
        return new AuthenticationResponse(Guid.NewGuid(), "Ken", "Simon", "ken@gmail.com", token);
    }
}