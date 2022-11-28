namespace BuberDinner.Tests;
using Xunit;
using FluentAssertions;

public class CollectionTest
{
    [Fact]
    public void CollectionCheck1()
    {
        IEnumerable<int> numbers = new[] { 1, 2, 3 };
        numbers.Should().OnlyContain(n => n > 0);
        numbers.Should().HaveCount(3);
    }
}