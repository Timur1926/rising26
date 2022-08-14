using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 5;
            int numberOfCrystals;
            Console.WriteLine($"Обменный курс {crystalPrice} золота = 1 кристал");
            Console.Write("Введите количества золота: ");
            int amauntGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Скольео кристалов вы хотите купит?: ");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            amauntGold -= numberOfCrystals * crystalPrice;
            Console.WriteLine($"Количество вашего золота: {amauntGold}");
            Console.WriteLine($"Количество ваших кристалов: {numberOfCrystals}");
        }
    }
}
