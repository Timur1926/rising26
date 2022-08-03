using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 5;

            Console.Write($"Введите количество золота в кошельке: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"=> цена за 1 крстала = {crystalPrice} золотых");
            Console.Write($"Какое количество кристалов вы хотите купить? - ");
            int crystals = Convert.ToInt32(Console.ReadLine());
            //int userCrystals = crystals;
            gold -= crystals * crystalPrice;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Количество золота у пользователя после сделки : {gold}");
            Console.WriteLine($"Количество кристалов у пользователя после сделки : {crystals}");
        }
    }
}
