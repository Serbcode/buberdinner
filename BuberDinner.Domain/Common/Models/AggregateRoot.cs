namespace BuberDinner.Domain.Common.Models;

public abstract class AggregateRoot<TID> : Entity<TID> where TID : notnull
{
    public AggregateRoot(TID id) : base(id)
    {
    }
}