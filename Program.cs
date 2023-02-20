using System;

namespace Healthbar
{
    class Program
    {
        static void Main(string[] args)
        {
            const double barValue = 20;
            double healthPercent;
            double manaPercent;
            string value;

            Console.Write("Введите количество жизни в процентах: ");
            value = Console.ReadLine();
            Double.TryParse(value, out healthPercent);
            Console.Write("Введите количество маны в процентах: ");
            value = Console.ReadLine();
            Double.TryParse(value, out manaPercent);

            DrawBar(healthPercent, barValue, ConsoleColor.DarkRed);
            DrawBar(manaPercent, barValue, ConsoleColor.DarkGreen);
        }

        static void DrawBar(double quantityPercent, double barValue, ConsoleColor consoleColor)
        {
            int barMax = 100;
            int barMin = 0;

            if (quantityPercent <= barMax && quantityPercent >= barMin)
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
            else
            {
                Console.WriteLine("Начни сначала!!! Проценты не корректны!!!");
            }

        }
    }
}

