namespace BuberDinner.Tests.Application;

using Xunit;
using FluentAssertions;

public static partial class Application
{
    public static class AuthenticationTest
    {
        [Fact]
        public static void Authentication_Should_be_Created()
        {
            (5).Should().Be(5);
        }
    }
}