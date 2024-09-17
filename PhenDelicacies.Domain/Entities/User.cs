namespace PhenDelicacies.Domain.Entities;

public class User
{
    public Guid Id { get; set; } = new Guid();
    public string Firstname { get; set; } = default!;
    public string Lastname { get; set;} = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
}