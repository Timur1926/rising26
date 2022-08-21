using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Выберите дествие из представленного ниже меню ***");
            Console.WriteLine("Изменение цвета консоли ----------------- клавтша 1");
            Console.WriteLine("Изменение фона консоли  ----------------- клавиша 2");
            Console.WriteLine("Изменеение размера консоли -------------- клавтша 3"); 
            Console.WriteLine("Темпиратура воздуха на завтра: ---------- клавиша 4");
            Console.WriteLine("Калькулятор с 4-мя операциями +,-,/,*: -- клавиша 5");
            Console.WriteLine("Завершить программу: ---------------------клавиша 6");

            int operationNumber = 0;
            int exit = 0;

           

            while (exit != 6)
            {
                Console.Write($"действие №: ");
                operationNumber = Convert.ToInt32(Console.ReadLine());

                switch (operationNumber)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        break;
                    case 3:
                        Console.WindowHeight = 40;
                        Console.WindowWidth = 60;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Random random = new Random();
                        int temperature = random.Next(-20, 20);
                        Console.WriteLine($"Темпиратура на завтра {temperature}");
                        break;
                    case 5:
                        Console.WriteLine("Колькулятор");
                        int number1, number2;
                        char mathOperation;
                        int resalt = 0;
                        Console.Write($"Введи первое число: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Введи второе число: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Выбери операцию: ");
                        mathOperation = Convert.ToChar(Console.ReadLine());
                        switch (mathOperation)
                        {
                            case '+':
                                resalt = number1 + number2;
                                Console.WriteLine($"{number1} + {number2} = {resalt}");
                                break;
                            case '-':
                                resalt = number1 + number2;
                                Console.WriteLine($"{number1} - {number2} = {resalt}");
                                break;
                            case '/':
                                resalt = number1 + number2;
                                Console.WriteLine($"{number1} : {number2} = {resalt}");
                                break;
                            case '*':
                                resalt = number1 + number2;
                                Console.WriteLine($"{number1} * {number2} = {resalt}");
                                break;
                        }
                        break;
                    case 6:
                        exit = 6;
                        Console.ResetColor();
                        Console.WindowHeight = 30;
                        Console.WindowWidth = 120;
                        break;
                }
            }
            
        }
    }
}
