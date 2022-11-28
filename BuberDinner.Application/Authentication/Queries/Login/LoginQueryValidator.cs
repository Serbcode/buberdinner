using BuberDinner.Application.Authentication.Queries.Login;
using FluentValidation;

namespace BuberDinner.Application.Authentication.Queries;

public class LoginQueryValidator : AbstractValidator<LoginQuery>
{
    public LoginQueryValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Password).NotEmpty();
    }
}