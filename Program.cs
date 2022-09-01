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

            for (int i = 0; i <= (summRandom += randomN); i++)
            {

                if (summRandom >= bottomDigitNumber && summRandom <= topDigitNumber)
                {
                    resalt += 1;
                }
                
            }

            Console.WriteLine("Количество трёхзначных чисел кратных N = "+ resalt);
        }
    }
}
