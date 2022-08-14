using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInLine;
            int timeForOnePerson = 10;
            int MinutesInHour = 60;
            Console.Write("Количество людей в очереди: ");
            numberOfPeopleInLine = Convert.ToInt32(Console.ReadLine());
            int waitingTimeMinutes = numberOfPeopleInLine * timeForOnePerson;
            int waitingTimeHour = waitingTimeMinutes / MinutesInHour;
            waitingTimeMinutes %= MinutesInHour;
            Console.WriteLine($"Вы должны остаять в очереди {waitingTimeHour} часа {waitingTimeMinutes} минут");
        }
    }
}
