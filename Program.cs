using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { };
            bool isProceed = true;
            string exit = "exit";
            string sum = "sum";
            string action;
            int result = 0;

            Console.WriteLine($"Вводим любые целые числа и нажимаем enter");
            Console.WriteLine($"Команда (sum) и нажатие enter даёт сумму рание введённых чисел");
            Console.WriteLine($"Команда (exit) и нажатие enter завершит программу");

            while (isProceed)
            {
                action = Console.ReadLine();

                if (action == exit)
                {
                    isProceed = false;
                    Console.WriteLine("Программа завершена!!!");
                }
                else if (action == sum)
                {

                    for (int i = 0; i < array.Length; i++)
                    {
                        result += array[i];
                    }

                    Console.WriteLine($"Сумма чисел = {result}");
                    result = 0;
                }
                else 
                {
                    int[] dynamicArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        dynamicArray[i] = array[i];
                    }

                    dynamicArray[dynamicArray.Length - 1] = Convert.ToInt32(action);
                    array = dynamicArray;
                }
            }

        }
    }
}
