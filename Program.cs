using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = { { 5, 10, 15 }, { 20, 20, 20 } };
            int resultSum = 0;
            int rowNumber0 =0;
            int rowNumber1 = 1;
            int columNumber0 =0;
            int resultMultiplication = 0;
            Console.WriteLine("Дан следующий массив");

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");

                    if (i == rowNumber1)
                        resultSum += mass[i, j];

                   
                }
                
                Console.WriteLine();
                resultMultiplication = mass[rowNumber0, columNumber0] * mass[rowNumber1, columNumber0];
            }

            Console.WriteLine($"Сумма в торой строки = {resultSum}");
            Console.WriteLine($"Произведение первого столбца = {resultMultiplication}");
        }
    }
}
