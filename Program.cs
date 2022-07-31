using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPictures = 54;
            int rowNumber = 0;
            int overTheTopPictures = 0;
            for (int i = 1; i <= userPictures; i++)
            {
                //int a = 1;
                if (i % 3 == 0)
                {
                    rowNumber++;
                }
                else
                {
                    if (overTheTopPictures == 2)
                    {
                        overTheTopPictures = 0;
                    }
                    overTheTopPictures++;
                }
            }
            Console.WriteLine($"Заполненых рядов {rowNumber}");
            Console.WriteLine($"Картинок сверх меры {overTheTopPictures}");

        }
        
       
    }
}
