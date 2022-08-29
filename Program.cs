using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSymbol;
            string countSymbol = "";
            int optionalIterator = 1;

            Console.Write("Введите своё имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите свой символ:");
            userSymbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i <= userName.Length + optionalIterator; i++)
            {
                countSymbol += userSymbol;
            }

            Console.WriteLine(countSymbol);
            Console.WriteLine(userSymbol + userName + userSymbol);
            Console.WriteLine(countSymbol);
        }
    }
}
