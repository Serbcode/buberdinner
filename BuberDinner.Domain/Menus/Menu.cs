using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.Dinners.ValueObjects;
using BuberDinner.Domain.Hosts.ValueObjects;
using BuberDinner.Domain.Menus.Entities;
using BuberDinner.Domain.Menus.ValueObjects;
using BuberDinner.Domain.MenuReviews.ValueObjects;

namespace BuberDinner.Domain.Menus;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _sections = new();
    private readonly List<DinnerId> _dinners = new();
    private readonly List<MenuReviewId> _reviews = new();
    
    private Menu(
        MenuId menuId,
        string name,
        string description,
        HostId hostId,
        DateTime createdDate,
        DateTime updatedDate)
        : base(menuId)
    {
        Name = name;
        Description = description;
        HostId = hostId;
        CreatedDateTime = createdDate;
        UpdatedDateTime = updatedDate;
        AverageRating = AverageRating.CreateNew();
    }

    public static Menu Create(string name, string description, HostId hostId)
    {
        return new(
            MenuId.CreateUnique(),
            name,
            description,
            hostId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }

    public string Name { get; }
    public string Description { get; }
    public AverageRating AverageRating { get; }

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    public HostId HostId { get; }
    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
    public IReadOnlyList<DinnerId> DinnerIds => _dinners.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _reviews.AsReadOnly();
}