namespace BuberDinner.Tests.Domain;
using Xunit;
using FluentAssertions;

using BuberDinner.Domain.Entities;

public static partial class Domain
{
    public static class UserEntityTest
    {
        [Fact]
        public static void TodoEntity_Should_be_Created()
        {
            var user = new User();
            user.Id.Should().NotBeEmpty();
        }
    }
}