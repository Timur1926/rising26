using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { };
            bool goOut = true;
            string exit = "exit";
            string sum = "sum";
            string action;
            int result = 0;
            int number = 0;
            int countElements = 1;

            while (goOut)
            {
                action = Console.ReadLine();

                if (action == exit)
                {
                    goOut = false;
                    Console.WriteLine("Программа завершена!!!");
                    action = null;
                }
                else if (action == sum)
                {
                    Console.WriteLine($"Сумма чисел = {result}");
                    number = 0;
                    action = null;
                }

                int[] dynamicArray = new int[array.Length + countElements];
                array = dynamicArray;
                array[number] += Convert.ToInt32(action);
                result += array[number];
            }

        }
    }
}
