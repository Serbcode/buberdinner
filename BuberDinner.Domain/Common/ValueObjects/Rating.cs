using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Common.ValueObjects;

public sealed class Rating : ValueObject
{
    private int _value;

    public int Value
    {
        get 
        { 
            return _value; 
        }
        set 
        {
            if (value <= 1) _value = 1;
            else if (value >= 5 ) _value = 5;
            else _value = value;
        }
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return _value;   
    }
}
