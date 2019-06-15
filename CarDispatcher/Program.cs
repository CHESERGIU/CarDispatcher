using System;

namespace CarDispatcher
{
    class Program
    {
        enum Priority
        {
            Low,
            High
        }

        static void Main(string[] args)
        {
            Priority value = (Priority)1;
            Console.WriteLine(value);
            Console.Read();
        }
    }
}
