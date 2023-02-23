using System;

namespace READINT
{
    class Program
    {
        static void Main(string[] args)
        {
            int convertedNumber;
            convertedNumber = Converter();
            Console.WriteLine($"Конвертированное число = {convertedNumber}");
        }

        static int Converter()
        {
            int number = 0;
            bool complete = false;
            string userNumber;

            while (complete != true)
            {
                Console.Write("Введите чило: ");
                userNumber = Console.ReadLine();
                complete = int.TryParse(userNumber, out number);
            }
            
            return number;
        }
    }
}
