using System;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisplayArray(numberArray);
            Shuffle(numberArray);
        }

        static void DisplayArray(int[]numberArray)
        {

            foreach (int tempArray in numberArray)
            {
                Console.Write(" " + tempArray + " | ");
            }

            Console.WriteLine();
        }

        static void Shuffle(int[]numberArray)
        {
            Random random = new Random();
            //int[] tempArray = numberArray;
            int maxValue = 10;
            int minValue = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                int index = random.Next(minValue, maxValue);
                Console.Write(" " + numberArray[index] + " | ");
            }

            Console.WriteLine();
        }
    }
}
