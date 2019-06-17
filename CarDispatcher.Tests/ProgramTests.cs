using System;
using Xunit;

namespace CarDispatcher.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WWhenTicketsForSupportRequestAre3MustReturn1()
        {
            // ARRANGE
            Ticket[] tickets = { };
            var ticket1 = new Ticket("CJ01ABC", Priority.Low);
            var ticket2 = new Ticket("CJ02DEF", Priority.High);
            var ticket3 = new Ticket("CJ02GHI", Priority.Low);
            var payment = new Dispatcher();

            
            payment.Add(ref tickets, ticket1);
            payment.Add(ref tickets, ticket2);
            payment.Add(ref tickets, ticket3);
            //// ACT
            payment.SelectMode(ref tickets);
            payment.Remove(ref tickets);

            //// ASSERT
            Assert.DoesNotContain(ticket2, tickets);
        }
        [Fact]
        public void WWhenTicketsForSupportRequestAreMultipleEntriesMustReturnResultPriorityAfterSelection()
        {
            // ARRANGE
            Ticket[] tickets = { };
            var payment = new Dispatcher();

            var ticket1 = new Ticket("CJ01ABC", Priority.Low);
            var ticket2 = new Ticket("CJ02DEF", Priority.High);
            payment.Add(ref tickets, ticket1);
            payment.Add(ref tickets, ticket2);
            //// ACT
            payment.SelectMode(ref tickets);
            payment.Remove(ref tickets);
            //// ASSERT
            Assert.DoesNotContain(ticket2, tickets);
            //New ARRANGE
            var ticket3 = new Ticket("CJ02GHI", Priority.Low);
            payment.Add(ref tickets, ticket3);
            var ticket4 = new Ticket("CJ02JKL", Priority.High);
            payment.Add(ref tickets, ticket4);
            //// ACT
            payment.SelectMode(ref tickets);
            payment.Remove(ref tickets);
            //// ASSERT
            Assert.DoesNotContain(ticket4, tickets);
        }
    }
}
