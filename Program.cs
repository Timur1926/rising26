using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPictures = 52;
            int numberOfColumns = 3;
            int fullRanks =  userPictures / numberOfColumns;
            int extraPictures = userPictures % numberOfColumns;
            Console.WriteLine($"Заполненых рядов {fullRanks}");
            Console.WriteLine($"Картинок сверх меры {extraPictures}");
        }
    }
}
