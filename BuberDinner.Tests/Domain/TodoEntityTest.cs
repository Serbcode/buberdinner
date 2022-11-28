using System.Data.Common;
using BuberDinner.Domain.Entities;
using Xunit;
using FluentAssertions;

namespace BuberDinner.Tests.Domain;

public static partial class Domain
{
    public static class TodoEntityTest
    {
        [Fact]
        public static void TodoEntity_Should_be_Created()
        {
            var todo = new Todo() {Id = 1, Title = "Test", Completed = false};
            todo.Id.Should().BeGreaterThan(0);
        }
    }
}
