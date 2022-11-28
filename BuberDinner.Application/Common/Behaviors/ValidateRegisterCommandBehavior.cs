using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Authentication.Common;
using ErrorOr;
using FluentValidation;
using MediatR;

namespace BuberDinner.Application.Common.Behaviors;

public class ValidateRegisterCommandBehavior : IPipelineBehavior<RegisterCommand, ErrorOr<AuthResult>>
{
    private readonly IValidator<RegisterCommand> _validator;

    public ValidateRegisterCommandBehavior(IValidator<RegisterCommand> validator)
    {
        _validator = validator;
    }

    public async Task<ErrorOr<AuthResult>> Handle(
        RegisterCommand command,
        RequestHandlerDelegate<ErrorOr<AuthResult>> next,
        CancellationToken cancellationToken)
    {
        // before the handler
        var validationResult = await _validator.ValidateAsync(command, cancellationToken);

        if (validationResult.IsValid)
        {
            return await next();
        }

        List<Error>? allerrors = validationResult.Errors
            .ConvertAll(fail => Error.Validation(fail.PropertyName, fail.ErrorMessage));

        return allerrors;
    }
}