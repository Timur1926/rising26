using System;

namespace READINT
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = GetReadint();
            Console.WriteLine($"Конвертированное число = {number}");
        }

        static int GetReadint()
        {
            int number = 0;
            bool isNumber = false;
            string userNumber;

            while (isNumber != true)
            {
                Console.Write("Введите чило: ");
                userNumber = Console.ReadLine();
                isNumber = int.TryParse(userNumber, out number);
            }
            
            return number;
        }
    }
}
