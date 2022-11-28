using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var problemDetails = new ProblemDetails()
        {
            Type = "https://www.rfc-editor.org/rfc/rfc7231#section-6.6.1",
            Title = "An error occurred while processing your request.",
            Status = StatusCodes.Status500InternalServerError,
        };

        context.Result = new ObjectResult(problemDetails);
        context.ExceptionHandled = true;
    }
}