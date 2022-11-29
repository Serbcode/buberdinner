using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Hosts.ValueObjects;

public sealed class HostId : ValueObject
{
    public string Value {get;}
    
    private HostId(string value) => Value = value;

    public static HostId Create(string hostId)
    {
        return new(hostId);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}