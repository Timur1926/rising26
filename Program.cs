﻿using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = { { 5, 10, 15 }, { 20, 20, 20 } };
            int resultSum = 0;
            int rowNumber = 1;
            int number = 1;
            int columNumber = 0;
            int resultMultiplication = mass[0,0];
            

            Console.WriteLine("Дан следующий массив");

            for ( int i = 0; i < mass.GetLength(0); i++)
            {

                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                
                Console.WriteLine();
            }

            for (int i = 0; i <= mass.GetLength(0); i++)
            {
                resultSum += mass[rowNumber, i];
            }

            resultMultiplication *= mass[rowNumber, columNumber];
            Console.WriteLine($"Сумма в торой строки = {resultSum}");
            Console.WriteLine($"Произведение первого столбца = {resultMultiplication}");
        }
    }
}
