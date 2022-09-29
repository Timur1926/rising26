using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int minRandom = 1;
            int maxRandom = 50;
            int firstElement = 0;
            int secondElement = 1;
            int arrayElements = 30;
            int[] mass = new int[arrayElements];
            Console.WriteLine("Массив из 30 элементов");

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(minRandom, maxRandom);
                Console.Write(mass[i] + "  ");
            }

            Console.WriteLine();
            int localNumber;
            int penultimateElement = mass.Length - secondElement - secondElement;
            int lastElementArray = mass.Length - secondElement;

            if (mass[firstElement] > mass[secondElement])
            {
                localNumber = mass[firstElement];
                Console.Write(localNumber + " ");
            }

            for (int i = 1; i < mass.Length - secondElement; i++)
            {
                if (i > firstElement && mass[i - secondElement] < mass[i] && mass[i] > mass[i + secondElement])
                {
                    localNumber = mass[i];
                    Console.Write(localNumber + "  ");
                }
            }

            if (mass[penultimateElement] < mass[lastElementArray])
            {
                localNumber = mass[lastElementArray];
                Console.Write(localNumber + "  ");
            }

            Console.WriteLine();
        }
    }
}
