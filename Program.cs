using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** User profile ***");
            Console.Write("Enter your name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Name: {firstName}\nLast name: {lastName}\nAge: {age}\nHeight: {height}см\nWeight: {weight}кг");
        }
    }
}
