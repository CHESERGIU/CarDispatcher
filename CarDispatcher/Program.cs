using System;

namespace CarDispatcher
{
    class Program
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
                new Car("Volkswagen", (Priority)1),
                new Car("Renault",0),
                new Car("Ford",  Priority.Low)
            };

            Console.WriteLine(cars[1].priority + " - " + cars[1].id);
            Priority value = (Priority)1;
            Console.WriteLine(value);
            Console.Read();
        }
    }
}
