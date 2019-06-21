using System;
using Xunit;

namespace CarDispatcher.Tests
{
    public class TicketTests
    {
        [Fact]
        public void HasHigherPriority_returns_true_compared_with_a_lower_priority_ticket()
        {
            var a = new Ticket("a", Priority.High);
            var b = new Ticket("b", Priority.Low);

            Assert.True(a.HasHigherPriority(b));
        }

        [Fact]
        public void HasHigherPriority_returns_false_compared_with_a_higher_priority_ticket()
        {
            var a = new Ticket("a", Priority.Low);
            var b = new Ticket("b", Priority.High);

            Assert.False(a.HasHigherPriority(b));
        }
    }
}
