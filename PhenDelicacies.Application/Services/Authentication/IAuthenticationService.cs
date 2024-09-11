using PhenDelicacies.Application.Services.Authentication.Dtos;

namespace PhenDelicacies.Application.Services.Authentication;

public interface IAuthenticationService
{
        AuthenticationResponse Login(string email, string password);
        AuthenticationResponse Register(string firstname, string lastname, string email, string password);

}