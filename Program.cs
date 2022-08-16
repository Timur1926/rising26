using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycleStart = 5;
            int endOfCycle = 96;
            int iteratorChange = 7;

            for (int i = cycleStart; i <= endOfCycle; i += iteratorChange)
            {
                Console.Write($"{i}  ");
            }

            Console.WriteLine();
        }
    }
}
