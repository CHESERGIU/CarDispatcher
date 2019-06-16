using System;
using static CarDispatcher.Car;

namespace CarDispatcher
{
    public static class Program
    {
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
            //Console.WriteLine(cars[4].priority + " - " + cars[4].id);
            var ticket1 = new Car("Renault", Priority.High);
            cars = SelectMode(cars);
            Remove(ref cars);
            Add(ref cars, ticket1);

            //Console.WriteLine(cars[4].priority + " - " + cars[4].id);
            Console.Read();

        }
    }
}
