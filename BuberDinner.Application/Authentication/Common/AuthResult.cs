using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Authentication.Common;

public record AuthResult 
(
    User User,
    string Token
);