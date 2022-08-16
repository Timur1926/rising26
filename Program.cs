using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string cycleСontinues = " ";

            while (cycleСontinues != exit)
            {
                Console.WriteLine($"Чтобы остановить выполнение программы введи команду: {cycleСontinues}");
                cycleСontinues = Console.ReadLine();
            }

            Console.WriteLine("Программа закончена!!!");
        }
    }
}
