using ErrorOr;

namespace BuberDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(code: "Auth.InvalidCredentials", description: "Invalid credentials.");
        public static Error InvalidLogin => Error.Validation(code: "Auth.InvalidLogin", description: "Invalid login.");
        public static Error InvalidPassword => Error.Validation(code: "Auth.InvalidPassword", description: "Invalid password.");
    }
}
