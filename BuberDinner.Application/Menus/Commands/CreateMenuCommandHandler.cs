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

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        // create menu
        var menu = Menu.Create(
            request.Name,
            request.Description,
            HostId.Create(request.HostId),    
            request.Sections
                .Select(section => MenuSection.Create(
                    section.Name,
                    section.Description,
                    section.Items.ConvertAll(item => MenuItem.Create(item.Name, item.Description))
                )).ToList());
        
        // persist menu
        _menuRepository.Add(menu);

        // return menu;
        return menu;
    }
}
