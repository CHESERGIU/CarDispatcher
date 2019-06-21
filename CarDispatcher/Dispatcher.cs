using System;

namespace CarDispatcher
{
    public class Dispatcher
    {
        Ticket[] tickets;

        public Dispatcher()
        {
            this.tickets = new Ticket[0] { };
        }

        public void Enqueue(Ticket ticket)
        {
            Array.Resize(ref tickets, tickets.Length + 1);
            this.tickets[tickets.Length - 1] = ticket;
        }

        public Ticket Dequeue()
        {
            var index = Max();
            Swap(0, index);
            return RemoveFirst();
        }

        private void Swap(int a, int b)
        {
            var temp = tickets[a];
            tickets[a] = tickets[b];
            tickets[b] = temp;
        }

        private int Max()
        {
            var max = 0;
            for(int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].HasHigherPriority(tickets[max]))
                {
                    max = i;
                }
            }

            return max;
        }

        private Ticket RemoveFirst()
        {
            Ticket result = tickets[0];
            Array.Copy(tickets, 1, tickets, 0, tickets.Length - 1);
            Array.Resize(ref tickets, tickets.Length - 1);
            return result;
        }
    }
}
