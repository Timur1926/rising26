using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int growth;
            double weight;
            Console.Write("Введите ваше имя: ");
            firstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            growth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш вес: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Ваше имя {firstName} фамилия {lastName} вам {age} лет.\nВаш рост {growth}\nВаш вес {weight}");
        }
    }
}
