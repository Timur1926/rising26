using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInLine;
            int timeForOnePerson = 10;
            int hour = 60;
            Console.Write("Количество людей в очереди: ");
            numberOfPeopleInLine = Convert.ToInt32(Console.ReadLine());
            int waitingTimeMinutes = numberOfPeopleInLine * timeForOnePerson;
            int waitingTimeHour = waitingTimeMinutes / hour;
            waitingTimeMinutes %= hour;
            Console.WriteLine($"Вы должны остаять в очереди {waitingTimeHour} часа {waitingTimeMinutes} минут");
        }
    }
}
