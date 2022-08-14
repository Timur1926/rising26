using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int exchangeRate = 5;
            int numberOfCrystals = 1;
            Console.WriteLine($"Обменный курс {exchangeRate} золота = {numberOfCrystals} кристал");
            Console.Write("Введите количества золота: ");
            int amauntGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Скольео кристалов вы хотите купит?: ");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            amauntGold -= numberOfCrystals * exchangeRate;
            Console.WriteLine($"Количество вашего золота: {amauntGold}");
            Console.WriteLine($"Количество ваших кристалов: {numberOfCrystals}");
        }
    }
}
