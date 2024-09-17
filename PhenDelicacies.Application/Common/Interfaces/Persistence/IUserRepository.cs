using PhenDelicacies.Domain.Entities;

namespace PhenDelicacies.Application.Common.Interfaces;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);    
}