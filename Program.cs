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

        static void DisplayArray(int[] numberArray)
        {
            foreach (int tempNumber in numberArray)
            {
                Console.Write(" " + tempNumber + " | ");
            }

            Console.WriteLine("\n");
        }

        static void Shuffle(int[] numberArray)
        {
            int tempNumber;
            int minValue = 0;
            Random random = new Random();

            for (int i = numberArray.Length - 1; i > 0; i--)
            {
                int randomJ = random.Next(minValue, i);
                tempNumber = numberArray[i];
                numberArray[i] = numberArray[randomJ];
                numberArray[randomJ] = tempNumber;
            }
        }
    }
}
