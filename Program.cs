using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Расчёт времени ожидания в очереди ***\n");
            int receptionTime = 10;
            Console.Write($"Введи количество людей в очереди: ");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            int hour = 0;
            int minute = 0;
            for (int i = 1; i <= numberOfPeople; i++)
            {
                if (minute == 50)
                {
                    minute = 0;
                    hour += 1;
                }
                else
                {
                    minute += receptionTime;
                }
            }
            Console.WriteLine($"Вы должны отстоять в очереди {hour} часа {minute} мин ");
        }
    }
}
