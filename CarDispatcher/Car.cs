using System;

namespace CarDispatcher
{
    public class Car
    {
        private readonly string id;
        private readonly Priority priority;

        public Car(string id, Priority priority)
        {
            this.id = id;
            this.priority = priority;
        }


        public static Car[] SelectMode(Car[] cars)
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

        public static void Remove(ref Car[] cars)
        {
            for (int i = 0; i < cars.Length - 1; i++)
            {
                cars[i] = cars[i + 1];
            }
            Array.Resize(ref cars, cars.Length - 1);
        }

        public static void Add(ref Car[] cars, Car ticket)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = ticket;
        }


    }
}