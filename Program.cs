using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mass = { };
            string action = "";
            string exit = "exit";
            string sum = "sum";
            int number = 0;
            int iteration = 0;
            int countElement = 1;

            while (action != "exit")
            {
                action = Console.ReadLine();
                string[] array = new string[mass.Length + countElement];
                array[array.Length - countElement] = action;
                mass = array;

                if (action == exit)
                {
                    Console.WriteLine("Программа завершина!!!");
                }
                else if (action != "sum")
                {
                    number += Convert.ToInt32(mass[iteration]);
                    iteration++;
                }
                else if (action == sum)
                {
                    Console.WriteLine("Результат сложения = " + number);
                    number = 0;
                    iteration++;
                }
            }
            
        }
    }
}
