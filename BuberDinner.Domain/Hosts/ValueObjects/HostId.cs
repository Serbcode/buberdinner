using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Hosts.ValueObjects;

public sealed class HostId : ValueObject
{
    public Guid Value {get;}
    
    private HostId(Guid value) => Value = value;

    public static HostId Create(string strGuid)
    {
        if (Guid.TryParse(strGuid, out var guid))
            return new(guid);
        else 
            throw new ArgumentException("HostId: Could not convert string to Guid");
    }

    public static HostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}