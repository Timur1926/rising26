using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userData = new List<int>();
            bool exit = true;
            string number;
            string sum = "sum";
            int result;

            Console.WriteLine("Пользователь может вводить числа");
            Console.WriteLine("Если пользователь введёт \"sum\" то на экран выведется сумма всех введённых ранее чисел");

            while (exit)
            {
                number = Console.ReadLine();

                try
                {

                    if (number.Equals(sum))
                    {
                        result = userData.Sum();
                        Console.WriteLine(result);
                        Console.Write("Для завершения программы пишем команду \"exit\"");
                        string finish = Console.ReadLine();

                        if (finish == "exit")
                        {
                            exit = false;
                        }

                        userData.Clear();
                    }
                    else
                    {
                        userData.Add(Int32.Parse(number));
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Не допустимое значение!!!");
                }
            }
        }
    }
}
