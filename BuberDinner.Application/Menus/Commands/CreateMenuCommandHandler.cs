using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Hosts.ValueObjects;
using BuberDinner.Domain.Menus;
using BuberDinner.Domain.Menus.Entities;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Menus.Commands;

public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    private readonly IMenuRepository _menuRepository;

    public CreateMenuCommandHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand cmd, CancellationToken cancellationToken)
    {
        var menu = Menu.Create(
            name: cmd.Name,
            description: cmd.Description,
            hostId: HostId.Create(cmd.HostId),    
            
            cmd.Sections
                .Select(section => MenuSection.Create(
                    section.Name,
                    section.Description,
                    section.Items.ConvertAll(item => MenuItem.Create(item.Name, item.Description))
                )).ToList());
        
        _menuRepository.Add(menu);
        
        await Task.CompletedTask;
        
        return menu;
    }
}
