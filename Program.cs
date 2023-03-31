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
            DisplayArray(numberArray);
        }

        static void DisplayArray(int[]numberArray)
        {

            foreach (int massiv in numberArray)
            {
                Console.Write(massiv + " | ");
            }

            Console.WriteLine();
        }

        static void Shuffle(int[]numberArray)
        {
            Random random = new Random();
            int[] tempArray = numberArray;

            for (int i = 0; i < numberArray.Length; i++)
            {
                int index = random.Next(0, 9);
                numberArray[i] = tempArray[index];
            }

        }
    }
}
