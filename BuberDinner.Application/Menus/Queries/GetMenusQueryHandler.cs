using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Menus;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Menus.Queries;

public class GetMenusQueryHandler : IRequestHandler<GetMenusQuery, ErrorOr<List<Menu>>>
{
    private readonly IMenuRepository _menuRepository;

    public GetMenusQueryHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<List<Menu>>> Handle(GetMenusQuery query, CancellationToken cancellationToken)
    {
        var menus = _menuRepository.GetList(query.HostId);
        
        await Task.CompletedTask;
        
        return menus.ToList();
    }
}
