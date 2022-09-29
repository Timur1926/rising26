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
            int number_1 = 1;
            int number_0 = 0;
            int number_28 = 28;
            int[] mass = new int[30];
            Console.WriteLine("Массив из 30 элементов");

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(minRandom, maxRandom);
                Console.Write(mass[i] + "  ");
            }

            Console.WriteLine();
            int localNumber;

            for (int i = 0; i < mass.Length - 1; i++)
            {

                if (i == number_0 && mass[i] > mass[i + number_1])
                {
                    localNumber = mass[i];
                    Console.Write(localNumber + "  ");
                }

                if (i > number_0 && mass[i - number_1] < mass[i] && mass[i] > mass[i + number_1])
                {
                    localNumber = mass[i];
                    Console.Write(localNumber + "  ");
                }

                if (i == number_28 && mass[i] < mass[i + number_1])
                {
                    localNumber = mass[i + 1];
                    Console.Write(localNumber + "  ");
                }

            }

            Console.WriteLine();
        }
    }
}
