using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите количество золота в кошельке: ");
            int amountOfGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=> цена крстала = 1 золото");
            Console.Write($"Какое количество кристалов вы хотите купить? - ");
            int numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            int gold = amountOfGold - numberOfCrystals;
            int userCrystals = numberOfCrystals;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Количество золота у пользователя после сделки : {gold}");
            Console.WriteLine($"Количество кристалов у пользователя после сделки : {userCrystals}");
        }
    }
}
