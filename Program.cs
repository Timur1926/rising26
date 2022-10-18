using System;

namespace ЯJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            int countElements = 30;
            int[] array = new int[countElements];
            int number = 1;
            int numberRepetitions = 0;
            int repeatingNumber = 0;
            int elementPosition = 1;
            int randomMin = 1;
            int randoMax = 4;
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomMin, randoMax);
                Console.Write(array[i] + "  ");
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - elementPosition])
                {
                    number += 1;
                }
                else
                {
                    number = 1;
                }

                if (numberRepetitions <= number)
                {
                    repeatingNumber = array[i - elementPosition];
                    numberRepetitions = number;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Повторяющееся число " + repeatingNumber);
            Console.WriteLine("----------------------");
            Console.WriteLine("Количество повторений " + numberRepetitions);
        }
    }
}
