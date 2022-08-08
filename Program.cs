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
            int notFullHour;
            minuteCount = receptionTime * peopleCount;
            notFullHour = minuteCount;
            hourCount = minuteCount / minutesInHour;
            if (minuteCount >= minutesInHour)
            {
                notFullHour %= minutesInHour;
            }
            Console.WriteLine($"Вы должны отстоять в очереди {hourCount} часа {notFullHour} мин");
        }
    }
}
