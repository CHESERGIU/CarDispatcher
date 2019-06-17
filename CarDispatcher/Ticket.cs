using System;

namespace CarDispatcher
{
    public class Ticket
    {
        private readonly string id;
        private readonly Priority priority;

        public Ticket(string id, Priority priority)
        {
            this.id = id;
            this.priority = priority;
        }

        public string CarNumber => id;

        public Priority Priority => priority;
    }
}