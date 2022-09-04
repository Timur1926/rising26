using System;


namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 3;
            int maxValue = 50;
            int number = 2;
            int degree = 1;
            int randomValue = random.Next(minValue, maxValue);
            int result;

            for (result = number; result < randomValue; result *= number)
            {
                ++degree;
            }

            Console.WriteLine($"Для числа {randomValue} будет {number} в степени {degree}, то есть {result}");
            Console.WriteLine($"А {randomValue} < {result}");
        }
    }
}
