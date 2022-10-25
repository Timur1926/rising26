using System;

namespace Сдвиг_значений_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine("Сдвиг массива на n значений заданных пользователем");

            foreach (int arrayFirst in array)
            {
                Console.Write(arrayFirst + "  ");
            }

            Console.WriteLine("\n----------");

            Console.Write("Ведите значание n: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int index;

            for (int i = 0; i < number; i++) 
            {
                index = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = index;
            }

            foreach (int arraySecond in array)
            {
                Console.Write(arraySecond + "  ");
            }

            Console.WriteLine();
        }
    }
}
