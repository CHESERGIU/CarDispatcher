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

        public string CarNumber => id;

        public Priority Priority => priority;
    }
}