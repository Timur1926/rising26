using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSymbol;
            int iterationNumber = 2;

            Console.Write("Введите своё имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите символ: ");
            userSymbol = Console.ReadLine();

            for (int i = 0; i <= iterationNumber; i++)
            {
                if (i == 0 || i == 2)
                {
                    for (int j = 1; j <= userName.Length + 2; j++)
                    {
                        Console.Write(userSymbol);
                    }
                }
                else if (i == 1)
                {
                    Console.Write($"{userSymbol}{userName}{userSymbol}");
                }
                Console.WriteLine();
            }
        }
    }
}
