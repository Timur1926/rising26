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
            int randomN = random.Next(lowerRangeRandom, upperRangeRandom);
            int topDigitNumber = 999;
            int bottomDigitNumber = 100;
            int summRandom = 0;
            int resalt = 0;

            while (summRandom <= topDigitNumber)
            {
                summRandom += randomN;

                if (summRandom >= bottomDigitNumber && summRandom <= topDigitNumber)
                {
                    resalt++;
                }
                
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которых N = {resalt}");
        }
    }
}
