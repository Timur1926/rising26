using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int countRows;
            int numberOfPictures = 52;
            int countColumns = 3;
            int extraPictures = numberOfPictures % countColumns;
            countRows = numberOfPictures / countColumns;
            Console.WriteLine($"Полностью заполненых рядов: {countRows}");
            Console.WriteLine($"Лишних картинок: {extraPictures}");
        }
    }
}
