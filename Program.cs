using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку скобок: ");
            string text = Console.ReadLine();
            int symbol = 0;
            int count = 0;
            int result = 0;
            int numberEquals = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == '(')
                    symbol++;
                else if (text[i] == ')')
                {
                    if (i != text.Length - 1 && text[i + 1] != '(')
                        count++;
                    symbol--;
                }
                if (symbol < numberEquals)
                {
                    break;
                }
                if (symbol == numberEquals)
                {
                    result = count;
                }

            }

            if (symbol == numberEquals)
                Console.WriteLine("Строка корректная " + text + "\n" + "Максимум глубина равняется: " + (result + 1));
            else Console.WriteLine("Ошибка! Не верная строка " + text);

        }
        
    
    }
}
