using BuberDinner.Application.Menus.Commands;
using BuberDinner.Contracts.Menu;
using BuberDinner.Domain.Menus;
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("hosts/{hostId}/menus")]
public class MenusController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _mediator;

    public MenusController(IMapper mapper, ISender mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMenu(CreateMenuRequest request, string hostId)
    {
        var command = _mapper.Map<CreateMenuCommand>((request, hostId));
        
        ErrorOr<Menu> createMenuResult = await _mediator.Send(command);
        
        return createMenuResult.Match
        (
            menu => Ok(_mapper.Map<MenuResponse>(menu)),
            errors => Problem(errors)
        );
    }  
}