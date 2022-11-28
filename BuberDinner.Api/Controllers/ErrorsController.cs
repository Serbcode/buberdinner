using BuberDinner.Application.Common.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]   
    public IActionResult Error()
    {
        Exception? exeption = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        
        // var (StatusCode, Message) = exeption switch
        // {
        //     DuplicateEmailException => (StatusCodes.Status409Conflict, "Email is already taken"),
        //     _ => (500, "Unexpected error")
        // };

        // return Problem(statusCode: StatusCode, title: Message);
        
        return Problem();
    }
}