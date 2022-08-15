using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCycles = 1;

            while(numberOfCycles > 0)
            {
                Console.WriteLine("Чтобы остановить выполнение программы введи: exit");
                string exit = Console.ReadLine();
                if (exit=="exit")
                {
                    break;
                }
                Console.ReadKey();
                numberOfCycles++;
            }

            Console.WriteLine("Программа закончена!!!");
        }
    }
}
