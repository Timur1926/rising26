using System;

namespace Сортировка_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 7, 9, 5, 8, 4, 6, 2, 3, 1};
            int value = 1;
            int[] sortArray = new int[10];
            Console.WriteLine("Массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
                
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[j] == value)
                    {
                        sortArray[i] = array[j];
                    }
                }

                value++;
            }

            array = sortArray;
            Console.WriteLine();
            Console.WriteLine("Сортированный массив");

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }

            Console.WriteLine();
        }
    }
}
