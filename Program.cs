using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lowerRangeRandom = 1;
            int upperRangeRandom = 27;
            int randomNumber = random.Next(lowerRangeRandom, upperRangeRandom);
            int maxNumber = 999;
            int minNumber = 100;
            int summRandom;
            int result = 0;
        
            for (summRandom = 0;  summRandom <= maxNumber; summRandom += randomNumber)
            {

                if (summRandom >= minNumber)
                {
                    result++;
                }

            }
            
            Console.WriteLine($"Количество трехзначных натуральных чисел, которых N = {result}");
        }
    }
}
