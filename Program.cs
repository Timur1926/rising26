using System;

namespace READINT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool complete = false;
            int convertedNumber = 0;

            while (complete != true)
            {
                Console.Write("Введите чило: ");
                string userNumber = Console.ReadLine();
                convertedNumber = Converter(userNumber, ref complete);
            }

            Console.WriteLine($"Конвертированное число = {convertedNumber}");
        }

        static int Converter(string userNumber,ref bool complete)
        {
            complete = int.TryParse(userNumber, out int number);
            return number;
        }
    }
}
