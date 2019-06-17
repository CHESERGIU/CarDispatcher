using System;
using System.Collections.Generic;
using System.Text;

namespace CarDispatcher
{
    public static class Dispatcher
    {

        public static Car[] SelectMode(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                var max = cars[0];
                if (max.Priority < cars[i].Priority)
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
