using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomN = random.Next(1, 27);
            int topThreeDigitNumber = 999;
            int bottomThreeDigitNumber = 100;
            int summRandom = 0;
            int resalt = 0;

            for (int i = 0; i <= topThreeDigitNumber; i++)
            {
                summRandom += randomN;

                if (summRandom >= bottomThreeDigitNumber && summRandom <= topThreeDigitNumber)
                {
                    resalt += 1;
                }
                
            }

            Console.WriteLine("Количество трёхзначных чисел кратных N = "+ resalt);
        }
    }
}
