using Xunit;

namespace CarDispatcher.Tests
{
    public class DispatcherTests
    {
        [Fact]
        public void Enques_a_single_ticket()
        {
            // Given
            var dispatcher = new Dispatcher();
            var a = new Ticket("a", Priority.Low);
            // When
            dispatcher.Enqueue(a);
            // Then
            Assert.Equal(a, dispatcher.Dequeue());
        }

        [Fact]
        public void Eqnueues_and_deques_multiple_tickets()
        {
            // Given
            var dispatcher = new Dispatcher();
            var a = new Ticket("a", Priority.Low);
            var b = new Ticket("b", Priority.Low);
            var c = new Ticket("c", Priority.Low);
            dispatcher.Enqueue(a);
            dispatcher.Enqueue(b);
            dispatcher.Enqueue(c);
            // When
            var actual = new Ticket[3];
            actual[0] = dispatcher.Dequeue();
            actual[1] = dispatcher.Dequeue();
            actual[2] = dispatcher.Dequeue();
            // Then
            Assert.Equal(new Ticket[] { a, b, c }, actual);
        }

        [Fact]
        public void Dequeues_tickes_based_on_their_priority()
        {
            // Given
            var dispatcher = new Dispatcher();
            var a = new Ticket("a", Priority.Low);
            var b = new Ticket("b", Priority.High);
            var c = new Ticket("c", Priority.Low);
            dispatcher.Enqueue(a);
            dispatcher.Enqueue(b);
            dispatcher.Enqueue(c);
            // When
            var actual = new Ticket[3];
            actual[0] = dispatcher.Dequeue();
            actual[1] = dispatcher.Dequeue();
            actual[2] = dispatcher.Dequeue();
            // Then
            Assert.Equal(new Ticket[] { b, a, c }, actual);
        }

        [Fact]
        public void Dequeues_tickes_based_on_their_priority_and_price()
        {
            // Given
            var dispatcher = new Dispatcher();
            var a = new Ticket("a", Priority.Low, 500);
            var b = new Ticket("b", Priority.High, 1200);
            var c = new Ticket("c", Priority.Low, 2500);
            dispatcher.Enqueue(a);
            dispatcher.Enqueue(b);
            dispatcher.Enqueue(c);
            // When
            var actual = new Ticket[3];
            actual[0] = dispatcher.Dequeue();
            actual[1] = dispatcher.Dequeue();
            actual[2] = dispatcher.Dequeue();
            // Then
            Assert.Equal(new Ticket[] { b, c, a }, actual);
        }
    }
}
