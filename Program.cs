using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSymbol;
            string countSymbol = "";

            Console.Write("Введите своё имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите свой символ:");
            userSymbol = Console.ReadLine();

            for (int i = -1; i <= userName.Length; i++)
            {
                Console.Write(userSymbol);
                if (i == userName.Length)
                {
                    Console.WriteLine();
                    Console.Write(userSymbol + userName + userSymbol);
                }
                countSymbol += userSymbol;
            }
            Console.WriteLine();
            Console.WriteLine(countSymbol);
            
        }
    }
}
