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
            int divider3 = 3;
            int divider5 = 5;
            int resalt = 0;
            
            for(int i = 0; i <= number; i++)
            {

                if (i % divider3 == 0 || i % divider5 == 0)
                {
                    resalt += i;
                }
                
            }
            
            Console.WriteLine(resalt);
        }
    }
}
