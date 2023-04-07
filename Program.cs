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
            foreach (int tempArray in numberArray)
            {
                Console.Write(" " + tempArray + " | ");
            }

            Console.WriteLine("\n");
        }

        static void Shuffle(int[] numberArray)
        {
            int tempNumber;
            int minValue = 0;
            int maxValue = 10;
            Random random = new Random();

            for (int i = numberArray.Length - 1; i > 0; i--)
            {
                int j = random.Next(minValue, maxValue);
                tempNumber = numberArray[i];
                numberArray[i] = numberArray[j];
                numberArray[j] = tempNumber;
            }
        }
    }
}
