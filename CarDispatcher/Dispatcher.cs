using System;

namespace CarDispatcher
{
    public class Dispatcher
    {
        public Ticket[] SelectMode(ref Ticket[] tickets)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                var max = tickets[0];
                if (max.Priority < tickets[i].Priority)
                {
                    max = tickets[i];
                    tickets[i] = tickets[0];
                    tickets[0] = max;
                }
            }

            return tickets;
        }

        public Ticket Remove(ref Ticket[] tickets)
        {
            for (int i = 0; i < tickets.Length - 1; i++)
            {
                tickets[i] = tickets[i + 1];
            }
            Array.Resize(ref tickets, tickets.Length - 1);
            return tickets[0];
        }

        public void Add(ref Ticket[] tickets, Ticket ticket)
        {
            Array.Resize(ref tickets, tickets.Length + 1);
            tickets[tickets.Length - 1] = ticket;
        }

    }
}
