using BuberDinner.Domain.Entities;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;



[ApiController]
[Route("{controller}")]
public class TodoController : ControllerBase
{
    private ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Todo>>> GetAll()
    {
        return Ok(await _todoService.GetAll());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Todo>> GetTodoById(int id)
    {
        Todo? todo = await _todoService.GetOne(id);
        if (todo == null)
        {
            return NotFound();
        }
        return Ok(todo);
    }
}