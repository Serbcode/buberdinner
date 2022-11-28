namespace BuberDinner.Tests;
using Xunit;
using FluentAssertions;

public class StringsTest
{
    [Fact]
    public void Test_String_should_not_be_Null()
    {
        string? theObject = null;
        theObject.Should().BeNull();
    }

    [Fact]
    public void String_Should_apply_template()
    {
        string? actual = "ABCDEFGHI";
        actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
    }
}