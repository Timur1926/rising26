using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = { { 5, 10, 15 }, { 20, 20, 20 } };
            int resultSum = 0;
            int rowNumber = 0;
            int number = 1;
            int columNumber = 0;
            int resultMultiplication = 0;
            Console.WriteLine("Дан следующий массив");

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                
                Console.WriteLine();
                resultSum = mass[rowNumber + number, columNumber] + mass[rowNumber + number, columNumber + number] + mass[rowNumber + number, columNumber + number + number];
                resultMultiplication = mass[rowNumber, columNumber] * mass[rowNumber + number, columNumber];
            }

            Console.WriteLine($"Сумма в торой строки = {resultSum}");
            Console.WriteLine($"Произведение первого столбца = {resultMultiplication}");
        }
    }
}
