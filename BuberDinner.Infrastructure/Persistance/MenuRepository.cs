using BuberDinner.Application.Common.Interfaces.Persistance;
using BuberDinner.Domain.Menus;

namespace BuberDinner.Infrastructure.Persistance;

public class MenuRepository : IMenuRepository
{
    private static readonly List<Menu> _menus = new();

    public void Add(Menu menu)
    {
        _menus.Add(menu);     
    }
}
