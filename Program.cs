using System;

namespace READINT
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Readint();
            Console.WriteLine($"Конвертированное число = {number}");
        }

        static int Readint()
        {
            int number = 0;
            bool isComplete = false;
            string userNumber;

            while (isComplete != true)
            {
                Console.Write("Введите чило: ");
                userNumber = Console.ReadLine();
                isComplete = int.TryParse(userNumber, out number);
            }
            
            return number;
        }
    }
}
