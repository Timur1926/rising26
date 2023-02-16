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
            bool parametrsCorrect = true;

            while (parametrsCorrect)
            {
                Console.Write("Введите количество жизни в процентах: ");
                healthPercent = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество маны в процентах: ");
                manaPercent = Convert.ToInt32(Console.ReadLine());
                parametrsCorrect = InterestCheck(healthPercent, manaPercent);
            }

            DrawBar(healthPercent, barValue, ConsoleColor.DarkRed, healthPercent, manaPercent);
            DrawBar(manaPercent, barValue, ConsoleColor.DarkGreen, healthPercent, manaPercent);

        }

        static void DrawBar(double quantityPercent, double barValue, ConsoleColor consoleColor, double percentHealth, double percentMana)
        {
            ConsoleColor defaultConsoleColor = Console.BackgroundColor;
            char simbol = '_';
            int percent = (int)quantityPercent;
            int allInterest = 100;
            Console.Write("[");
            quantityPercent = (barValue / allInterest) * quantityPercent;
            Console.BackgroundColor = consoleColor;
            string bar = new string(simbol, (int)quantityPercent);
            Console.Write(bar);
            quantityPercent = barValue - quantityPercent;
            Console.BackgroundColor = defaultConsoleColor;
            bar = new string(simbol, (int)quantityPercent);
            Console.Write(bar);
            Console.Write("]" + " " + percent + "%" + "\n");
        }

        static bool InterestCheck(double percentHealth, double percentMana)
        {
            int barMax = 100;
            int barMin = 0;
            bool parametrsCorrect = true;

            if (percentHealth <= barMax && percentHealth >= barMin && percentMana <= barMax && percentMana >= barMin)
            {
                parametrsCorrect = false;
            }
            else
            {
                Console.WriteLine("Ошибка при вводе процентов!!! Попробуй ещё!!");
            }

            return parametrsCorrect;
        }
    }
}

