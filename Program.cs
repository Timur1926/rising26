using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { };
            string action = null;
            int countElements = 1;
            int number = 0;
            int result = 0;

            while(action != "exit")
            {
                int[] array = new int[mass.Length + countElements];
                mass = array;
                action = Console.ReadLine();

                if (action == "exit") 
                { }
                else if (action != "sum")
                {
                    mass[number] = Convert.ToInt32(action);
                    result += mass[number];
                }
                else if (action == "sum")
                {
                    Console.WriteLine($"Результат сложения = {result}");
                    result = 0;
                }
            }

            Console.WriteLine("Программа заверена!!!");
        }
    }
}
