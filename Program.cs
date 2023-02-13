using System;

namespace Healthbar
{
    class Program
    {
        static void Main(string[] args)
        {
            const int boundsCheck = 100;
            Console.Write("Введите количество жизни в процентах: ");
            double heathPercent = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество маны в процентах: ");
            double manaPercent = Convert.ToInt32(Console.ReadLine());

            if (heathPercent <= boundsCheck && manaPercent <= boundsCheck)
            {
                DrawBar(heathPercent, 20, ConsoleColor.DarkRed);
                DrawBar(manaPercent, 20, ConsoleColor.DarkGreen);
            }
            else
            {
                Console.WriteLine("!!!ERROR!!! Попробуё ещё!");
            }
            
        }

        static void DrawBar(double quantity, double barValue, ConsoleColor consoleColor)
        {
            ConsoleColor defaultConsoleColor = Console.BackgroundColor;
            char simbol = '_';
            int percent = (int)quantity;
            int allInterest = 100;
            Console.Write("[");
            quantity = (barValue / allInterest) * quantity;

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
                }

            }

            Console.BackgroundColor = defaultConsoleColor;
            Console.Write("]" + " " + percent + "%");
            Console.WriteLine();
        }
    }
}

