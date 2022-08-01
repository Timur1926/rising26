using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите количество золота в кошельке: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=> цена крстала = 1 золото");
            Console.Write($"Какое количество кристалов вы хотите купить? - ");
            int crystals = Convert.ToInt32(Console.ReadLine());
            int userCrystals = gold - crystals;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Количество золота у пользователя после сделки : {gold - crystals}");
            Console.WriteLine($"Количество кристалов у пользователя после сделки : {userCrystals}");
        }
    }
}
