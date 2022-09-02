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
            int degree;
            int randomValue = random.Next(minValue, maxValue);
            int result;

            Console.WriteLine($"Введите минимальную степень числа {number2} чтоб оно было больше {randomValue}");
            Console.Write("Минимальная степень: ");
            degree = Convert.ToInt32(Console.ReadLine());

            for (result = number2; randomValue >= result; result *= number2)
            {
                
            }

            Console.WriteLine($"Для числа {randomValue} будет {number2} в степени {degree}, то есть {result}");
            Console.WriteLine($"А {randomValue} < {result}");
        }
    }
}
