using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumRandom = 101;
            int number = random.Next(0,maximumRandom);
            int dividerFirst = 3;
            int dividerSecond = 5;
            int resalt = 0;
            
            for(int i = 0; i <= number; i++)
            {
                if (i % dividerFirst == 0 || i % dividerSecond == 0)
                {
                    resalt += i;
                }
            }
            
            Console.WriteLine(resalt);
        }
    }
}
