using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _menuItems = new();
    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();

    public string Name { get; }
    public string Description { get; }
    
    public MenuSection(MenuSectionId id, string name, string description)
     : base(id)
    {
        Name = name;
        Description = description;
    }

    public static MenuSection CreateUnique(string name, string description)
    {
        return new(MenuSectionId.CreateUnique(), name, description);
    }
}