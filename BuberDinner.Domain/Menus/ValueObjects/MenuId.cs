using System.Runtime.CompilerServices;
using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menus.ValueObjects;

public sealed class MenuId : ValueObject
{
    public Guid Value {get;}
    
    private MenuId(Guid value) => Value = value;

    public static MenuId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}