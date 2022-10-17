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
            int elementI = 1;
            int randomMin = 1;
            int randoMax = 4;
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomMin, randoMax);
                Console.Write(array[i] + "  ");

                if (i > 0)
                {
                    if (array[i] == array[i - elementI])
                    {
                        number += 1;
                    }
                    else
                    {
                        number = 1;
                    }
                    if (numberRepetitions <= number)
                    {
                        repeatingNumber = array[i - elementI];
                        numberRepetitions = number;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Повторяющееся число " + repeatingNumber);
            Console.WriteLine("----------------------");
            Console.WriteLine("Количество повторений " + numberRepetitions);
        }
    }
}
