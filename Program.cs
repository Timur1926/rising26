using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            string userСommand;

            while (exit == true)
            {
                Console.WriteLine("Чтобы остановить выполнение программы введи команду: exit");
                userСommand = Console.ReadLine();

                if (userСommand == "exit")
                {
                    exit = false;
                }

            }

            Console.WriteLine("Программа закончена!!!");
        }
    }
}
