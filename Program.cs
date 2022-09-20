using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = { { 20, 20, 20, 20}, { 10, 10, 10, 10} };
            int resultSum = 0;
            int resultMultiplication = 0;
            int rowNumber = 1;
            int columNumber = 0;
            
            Console.WriteLine("Дан следующий массив");

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < mass.GetLength(1); i++)
            {
                resultSum += mass[rowNumber, i];
            }

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                resultMultiplication = mass[i, columNumber];
                resultMultiplication *= mass[++i, columNumber];
            }

            Console.WriteLine($"Сумма в торой строки = {resultSum}");
            Console.WriteLine($"Произведение первого столбца = {resultMultiplication}");
        }
    }
}
