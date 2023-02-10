using System;

namespace Healthbar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество жизни в процентах: ");
            int heath = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество маны в процентах: ");
            int mana = Convert.ToInt32(Console.ReadLine());
            DrawBar(heath, ConsoleColor.DarkRed);
            DrawBar(mana, ConsoleColor.DarkGreen);
        }

        static void DrawBar(int quantity, ConsoleColor consoleColor)
        {
            int barValue = 100;
            ConsoleColor defaultConsoleColor = Console.BackgroundColor;
            char simbol = '_';
            int percent = 0;
            Console.Write("[");

            for (int i = 1; i <= barValue; i++)
            {

                if (i <= quantity)
                {
                    Console.BackgroundColor = consoleColor;
                    Console.Write(simbol);
                }
                else
                {
                    Console.BackgroundColor = defaultConsoleColor;
                    Console.Write(simbol);
                    percent++;
                }

            }

            percent = barValue - percent;
            Console.BackgroundColor = defaultConsoleColor;
            Console.Write("]"+" "+ percent+"%");
            Console.WriteLine();
        }
    }
}
