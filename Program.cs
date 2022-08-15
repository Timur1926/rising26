using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCyclest;
            string userMessage;
            Console.Write("Введите желаемое количество циклов: ");
            numberOfCyclest = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваше сообщение: ");
            userMessage = Console.ReadLine();
            for (int i = 1; i <= numberOfCyclest; i++)
            {
                Console.WriteLine($"{i}) {userMessage}");
            }
        }
    }
}
