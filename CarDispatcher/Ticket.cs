using System;

namespace CarDispatcher
{
    public class Ticket
    {
        private readonly string id;
        private readonly Priority priority;
        private readonly decimal price;

        public Ticket(string id, Priority priority, decimal price = 0)
        {
            this.id = id;
            this.priority = priority;
            this.price = price;
        }

        public bool HasHigherPriority(Ticket other)
        {
            return this.priority > other.priority
                || (this.price > other.price && this.priority == other.priority);
        }

        public override string ToString()
        {
            return $"{id} - {priority}";
        }
    }
}