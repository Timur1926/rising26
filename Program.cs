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
            int number2 = 2;
            int degree = 1;
            int randomValue = random.Next(minValue, maxValue);
            int result;

            for (result = number2; result < randomValue; result *= number2)
            {
                ++degree;
            }

            Console.WriteLine($"Для числа {randomValue} будет {number2} в степени {degree}, то есть {result}");
            Console.WriteLine($"А {randomValue} < {result}");
        }
    }
}
