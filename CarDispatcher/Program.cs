using System;
using System.Net.Sockets;

namespace CarDispatcher
{
    internal static class Program
    {
        private enum Priority
        {
            Low,
            High
        }

        private struct Car
        {
            public readonly string id;
            public readonly Priority priority;

            public Car(string id, Priority priority)
            {
                this.id = id;
                this.priority = priority;
            }
        }

        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car("Volkswagen", Priority.Low),
                new Car("Opel", Priority.Low),
                new Car("Mercedes", Priority.Low),
                new Car("Fiesta", Priority.Low)
            };
            
            var ticket = new Car("Ford", Priority.High);
            Add(ref cars, ticket);
            Console.WriteLine(cars[4].priority + " - " + cars[4].id);
            var ticket1 = new Car("Renault", Priority.High);
            cars = SelectMode(cars);
            Remove(ref cars);
            Add(ref cars, ticket1);
            cars = SelectMode(cars);
            Console.WriteLine(cars[0].priority + " - " + cars[0].id);
            Console.Read();

        }

        private static Car[] SelectMode(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                var max = cars[0];
                if (max.priority < cars[i].priority)
                {
                    max = cars[i];
                    cars[i] = cars[0];
                    cars[0] = max;
                }
            }

            return cars;
        }

        private static void Remove(ref Car[] cars)
        {
            for (int i = 0; i < cars.Length - 1; i++)
            {
                cars[i] = cars[i + 1];
            }
            Array.Resize(ref cars, cars.Length - 1);
        }

        private static void Add(ref Car[] cars, Car ticket)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = ticket;
        }

    }
}
