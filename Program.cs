using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** User profile ***");
            Console.Write("Enter your name: ");
            string myName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string myLastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height: ");
            int myHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your weight: ");
            double myWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Name: {myName}\nLast name: {myLastName}\nAge: {myAge}\nHeight: {myHeight}см\nWeight: {myWeight}кг");
        }
    }
}
