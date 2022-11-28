using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
    void AddUser(User user);
    User? GetUserByEmail(string email);
}