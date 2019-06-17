using System;

namespace CarDispatcher
{
    public static class Dispatcher
    {
        public static Ticket[] SelectMode(Ticket[] tickets)
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

        public static void Remove(ref Ticket[] tickets)
        {
            for (int i = 0; i < tickets.Length - 1; i++)
            {
                tickets[i] = tickets[i + 1];
            }
            Array.Resize(ref tickets, tickets.Length - 1);
        }

        public static void Add(ref Ticket[] tickets, Ticket ticket)
        {
            Array.Resize(ref tickets, tickets.Length + 1);
            tickets[tickets.Length - 1] = ticket;
        }

    }
}
