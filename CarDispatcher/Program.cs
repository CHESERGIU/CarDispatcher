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
            var payment = new Dispatcher();
            //NEW Ticket
            var ticket = new Ticket("Ford", Priority.High);
            payment.Add(ref tickets, ticket);
            foreach (var car in tickets)
            {
                Console.WriteLine("1 - " + car.Priority + " - " + car.CarNumber);
            }
            tickets = payment.SelectMode(ref tickets);
            foreach (var car in tickets)
            {
                Console.WriteLine("2 - " + car.Priority + " - " + car.CarNumber);
            }
            payment.Remove(ref tickets);
            foreach (var car in tickets)
            {
                Console.WriteLine("3 - " + car.Priority + " - " + car.CarNumber);
            }
            //NEW Ticket
            var ticket1 = new Ticket("Renault", Priority.High);
            payment.Add(ref tickets, ticket1);
            foreach (var car in tickets)
            {
                Console.WriteLine("4 - " + car.Priority + " - " + car.CarNumber);
            }
            tickets = payment.SelectMode(ref tickets);
            payment.Remove(ref tickets);
            foreach (var car in tickets)
            {
                Console.WriteLine("5 - " + car.Priority + " - " + car.CarNumber);
            }
            //No new tickets
            payment.Remove(ref tickets);
            foreach (var car in tickets)
            {
                Console.WriteLine("6 - " + car.Priority + " - " + car.CarNumber);
            }
            payment.Remove(ref tickets);
            foreach (var car in tickets)
            {
                Console.WriteLine("7 - " + car.Priority + " - " + car.CarNumber);
            }
            payment.Remove(ref tickets);
            foreach (var car in tickets)
            {
                Console.WriteLine("8 - " + car.Priority + " - " + car.CarNumber);
            }

            Console.Read();

        }
    }
}
