using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { };
            bool exit = true;
            string action = null;
            int result = 0;
            int number = 0;
            int countElements = 1;

            while (exit)
            {
                action = Console.ReadLine();

                if (action == "exit")
                {
                    exit = false;
                    Console.WriteLine("Программа завершена!!!");
                    action = null;
                }
                if (action == "sum")
                {
                    Console.WriteLine($"Сумма чисел = {result}");
                    number = 0;
                    result = 0;
                    action = null;
                }

                int[] dynamicArray = new int[array.Length + countElements];
                array = dynamicArray;
                array[number] += Convert.ToInt32(action);
                result += array[number];
                number++;
            }

        }
    }
}
