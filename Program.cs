using System;

namespace SPLIT
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Скажика дядя ведь не даром Москва сполённая пожаром была французу отдана";
            Console.WriteLine(text + "\n");
            string[] arrayText = text.Split(' ');

            foreach(string elementText in arrayText)
            {
                Console.WriteLine(elementText);
            }

            Console.WriteLine();
        }
    }
}
