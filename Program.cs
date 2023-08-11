using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string inputUser;
            int numberUser;
            bool isNumber;
            string exit = "exit";
            string sumNumbers = "sum";
            bool canExit = true;
            
            Console.WriteLine("=> Пользователь вводит целые числа");
            Console.WriteLine($"=> команда ({sumNumbers}) выводит сумму всех чисел");
            Console.WriteLine($"=> Команда ({exit}) завершает программу");
            
            while (canExit)
            {
                Console.Write("Введи команду: ");
                inputUser = Console.ReadLine();
                isNumber = int.TryParse(inputUser, out numberUser);

                if (isNumber)
                {
                    numbers.Add(numberUser);
                }
                else if (inputUser == sumNumbers)
                {
                    ShowDisplay(numbers);
                }
                else if (inputUser == exit)
                {
                    canExit = false;
                }
                else
                {
                    Console.WriteLine($"ERROR!!! Таких команд в меню нет, попробуй снова!!!");
                }
            }
        }

        public static void ShowDisplay(List<int>numbers)
        {
            Console.WriteLine($"Сумма всех введённых чисел = {numbers.Sum()}");
            numbers.Clear();
        }
    }
}
