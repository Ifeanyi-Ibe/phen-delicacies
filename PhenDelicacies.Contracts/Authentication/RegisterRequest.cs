namespace PhenDelicacies.Contracts.Authentication;

public record RegisterRequest(string Firstname, string Lastname, string Email, string Password);