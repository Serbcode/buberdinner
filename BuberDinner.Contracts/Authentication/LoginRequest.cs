namespace BuberDinner.Contracts.Authentication;

public record class LoginRequest (
    string Email,
    string Password
);