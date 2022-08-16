using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0,101);
            int divider3 = 3;
            int divider5 = 5;
            int resalt = 0;
            
            for(int i = 0; i <= number; i++)
            {

                if (i % divider3 == 0 && i <= number)
                {
                    resalt += i;
                }
                else if (i % divider5 == 0 && i <= number)
                {
                    resalt += i;
                }
                
            }
            
            Console.WriteLine(resalt);
        }
    }
}
