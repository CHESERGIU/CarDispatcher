using System;

namespace CarDispatcher
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Ticket[] tickets =
            {
                new Ticket("Volkswagen", Priority.Low),
                new Ticket("Opel", Priority.Low),
                new Ticket("Mercedes", Priority.Low),
                new Ticket("Fiesta", Priority.Low)
            };
            
            var ticket = new Ticket("Ford", Priority.High);
            Dispatcher.Add(ref tickets, ticket);
            Console.WriteLine(tickets[4].Priority + " - " + tickets[4].CarNumber);
            var ticket1 = new Ticket("Renault", Priority.High);
            tickets = Dispatcher.SelectMode(tickets);
            Dispatcher.Remove(ref tickets);
            Dispatcher.Add(ref tickets, ticket1);

            Console.WriteLine(tickets[4].Priority + " - " + tickets[4].CarNumber);
            Console.Read();

        }
    }
}
