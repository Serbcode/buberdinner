using BuberDinner.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Authentication.Commands.Register;

public sealed record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthResult>>;