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
            int peopleCount = Convert.ToInt32(Console.ReadLine());
            int hourCount;
            int minuteCount;
            int minutesInHour = 60;
            int minutes;
            minuteCount = receptionTime * peopleCount;
            minutes = minuteCount;
            hourCount = minuteCount / minutesInHour;
            if (minuteCount >= minutesInHour)
            {
                minutes %= minutesInHour;
            }
            Console.WriteLine($"Вы должны отстоять в очереди {hourCount} часа {minutes} мин");
        }
    }
}
