using PhenDelicacies.Application.Services.Authentication.Dtos;

namespace PhenDelicacies.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResponse Login(string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), "Ken", "Simon", "ken@gmail.com", "skjrfkjaksj32je");
    }

    public AuthenticationResponse Register(string firstname, string lastname, string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), "Ken", "Simon", "ken@gmail.com", "skjrfkjaksj32je");
    }
}