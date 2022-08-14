using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Kutupov";
            string lastName = "Timur";
            string changeData;
            Console.WriteLine($"{firstname} {lastName}");
            changeData = firstname;
            firstname = lastName;
            lastName = changeData;
            Console.WriteLine("--------------");
            Console.WriteLine($"{firstname} {lastName}");
        }
    }
}
