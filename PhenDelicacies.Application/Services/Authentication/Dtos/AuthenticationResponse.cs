namespace PhenDelicacies.Application.Services.Authentication.Dtos;

public record AuthenticationResponse(Guid Id, string Firstname, string Lastname, string Email, string Token);