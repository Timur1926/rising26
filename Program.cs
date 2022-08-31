using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberAttempts = 3;
            int attempts = 3;
            Console.WriteLine("=> Для того чтоб увидеть секретное сообщение введите пороль!!!");
            Console.Write($"У вас {numberAttempts} попытки: ");
            string password = "RRR2022";

            for (int i = 1; i <= numberAttempts; i++)
            {
                string enterPasword = Console.ReadLine();

                if (password == enterPasword.ToUpper())
                {

                    Console.WriteLine("Поздравляем вы HAPPY!!!!");
                    i = numberAttempts;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"У вас осталось {attempts} попыток!!!");
                }
            }

        }
    }
}
