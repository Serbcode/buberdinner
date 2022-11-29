using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menus.ValueObjects;

namespace BuberDinner.Domain.Menus.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _menuItems = new();
    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();

    public string Name { get; }
    public string Description { get; }
    
    public MenuSection(MenuSectionId id,
                       string name,
                       string description,
                       List<MenuItem> menuItems)
     : base(id)
    {
        Name = name;
        Description = description;
        _menuItems = menuItems;
    }

    public static MenuSection Create(string name,
                                           string description,
                                           List<MenuItem> menuItems)
    {
        return new(MenuSectionId.CreateUnique(), name, description, menuItems);
    }
}