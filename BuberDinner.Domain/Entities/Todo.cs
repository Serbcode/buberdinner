namespace BuberDinner.Domain.Entities;

public record Todo
{
    public int Id { get; init; }
    public string Title { get; init; } = null!;
    public bool Completed { get; init; }
}