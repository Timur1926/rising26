using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPictures = 52;
            int fullRanks =  userPictures / 3;
            int extraPictures = userPictures % 3;
            Console.WriteLine($"Заполненых рядов {fullRanks}");
            Console.WriteLine($"Картинок сверх меры {extraPictures}");
        }
    }
}
