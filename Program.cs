using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberMin = 1;
            int numberMax = 50;
            int largestElement = 0;
            int changeLargestElement = 0;
            int countLargestElement = 0;
            int[,] mass = new int[10, 10];

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(numberMin, numberMax);
                    Console.Write(mass[i,j] + "\t");

                    if (mass[i, j] > largestElement)
                    {
                        largestElement = mass[i, j];
                    }

                }
                Console.WriteLine("");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine(largestElement + " - максимальный элемент массива" + "\n");

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {

                    if (mass[i,j] == largestElement)
                    {
                        mass[i, j] = changeLargestElement;
                        countLargestElement++;
                    }

                    Console.Write(mass[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Максимальный элемент {largestElement} - {countLargestElement} шт");
        }   
    }
}
