using PhenDelicacies.Application.Common.Interfaces;
using PhenDelicacies.Application.Services.Authentication.Dtos;
using PhenDelicacies.Domain.Entities;

namespace PhenDelicacies.Application.Services.Authentication;

public class AuthenticationService(IJwtTokenGenerator tokenGenerator, IUserRepository userRepository) : IAuthenticationService
{
    private readonly IJwtTokenGenerator _tokenGenerator = tokenGenerator;
    private readonly IUserRepository _userRepository = userRepository;

    public AuthenticationResponse Login(string email, string password)
    {
        if(_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("Invalid credentials.");
        }

        if(user.Password != password)
        {
            throw new Exception("Invalid credentials.");
        }

        var token = _tokenGenerator.GenerateToken(user.Id, user.Firstname, user.Lastname);

        return new AuthenticationResponse(user.Id, user.Firstname, user.Lastname, user.Email, token);
    }

    public AuthenticationResponse Register(string firstname, string lastname, string email, string password)
    {
        if(_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with given email already exists.");
        }

        var user = new User {
            Firstname = firstname,
            Lastname = lastname,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);

        var token = _tokenGenerator.GenerateToken(user.Id, firstname, lastname);
        
        return new AuthenticationResponse(user.Id, firstname, lastname, email, token);
    }
}