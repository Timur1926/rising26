using System;

namespace Healthbar
{
    class Program
    {
        static void Main(string[] args)
        {
            const double barValue = 20;
            double healthPercent = 0.0;
            double manaPercent = 0.0;
            bool parametersCorrect = false;

            while (parametersCorrect == false)
            {
                Console.Write("Введите количество жизни в процентах: ");
                healthPercent = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество маны в процентах: ");
                manaPercent = Convert.ToInt32(Console.ReadLine());
                parametersCorrect = InterestСheck(healthPercent, manaPercent);
            }

            DrawBar(healthPercent, barValue, ConsoleColor.DarkRed);
            DrawBar(manaPercent, barValue, ConsoleColor.DarkGreen);
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

        static bool InterestСheck(double percentHealth, double percentMana)
        {
            double maxValue = 100;
            double minValue = 0;
            bool parametersСorrect = false;

            if (percentHealth <= maxValue && percentHealth >= minValue && percentMana <= maxValue && percentMana >= minValue)
            {
                parametersСorrect = true;
            }
            else
            {
                Console.WriteLine("!!! ERROR !!! Попробуй ещё!");
            }

            return parametersСorrect;
        }
    }
}

