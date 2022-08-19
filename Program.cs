using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdRub = 60.54;
            double usdSek = 9.07;
            double rubUsd = 0.02;
            double rubSek = 0.17;
            double sekRub = 5.75;
            double sekUsd = 0.11;
            double yourBalanceInUsd = 10000;
            double yourBalanceInRub = 10000;
            double yourBalanceInSek = 10000;
            string proceed = "8";
            string exit = "7";
            int countUsd;
            int countRub;
            int countSek;


            Console.WriteLine("*** Обменный курс на сегодня ***");
            Console.WriteLine("USD/RUB = 60.54  №1");
            Console.WriteLine("USD/SEK = 9.07   №2");
            Console.WriteLine("RUB/USD = 0.02   №3");
            Console.WriteLine("RUB/SEK = 0.17   №4");
            Console.WriteLine("SEK/RUB = 5.75   №5");
            Console.WriteLine("SEK/USD = 0.11   №6");
            Console.WriteLine("Для завершения   №7");
            Console.WriteLine("Для продолжения  №8");
             
            while (proceed != exit)
            {
                Console.Write("Выбери № операции из представленного выше списка: ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.Write("Введите количество долларов: ");
                        countUsd = Convert.ToInt32(Console.ReadLine());
                        yourBalanceInUsd += countUsd;
                        yourBalanceInRub -= countUsd * usdRub;
                        Console.WriteLine("Количество USD на счёте:" + yourBalanceInUsd);
                        Console.WriteLine("Количество RUB на счёте:" + yourBalanceInRub);
                        Console.Write("Желаете завершить/продолжить? ");
                        proceed = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Введите количество долларов: ");
                        countUsd = Convert.ToInt32(Console.ReadLine());
                        yourBalanceInUsd += countUsd;
                        yourBalanceInSek -= countUsd * usdSek;
                        Console.WriteLine($"Количество долларов на счёте: {yourBalanceInUsd}");
                        Console.WriteLine($"Количество шведских крон на счёте: {yourBalanceInSek}");
                        Console.Write("Желаете закончить/продолжить? ");
                        proceed = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Введите количетсво рублей: ");
                        countRub = Convert.ToInt32(Console.ReadLine());
                        yourBalanceInRub += countRub;
                        yourBalanceInUsd -= countRub * rubUsd;
                        Console.WriteLine($"Количество рублей на счёте: {yourBalanceInRub}");
                        Console.WriteLine($"Количество долларов на счёте: {yourBalanceInUsd}");
                        Console.Write("Желаете закончить/продолжить? ");
                        proceed = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Введите количетсво рублей: ");
                        countRub = Convert.ToInt32(Console.ReadLine());
                        yourBalanceInRub += countRub;
                        yourBalanceInSek -= countRub * rubSek;
                        Console.WriteLine($"Количество рублей на счёте: {yourBalanceInRub}");
                        Console.WriteLine($"Количество шведских крон на счёте: {yourBalanceInSek}");
                        Console.Write("Желаете закончить/продолжить? ");
                        proceed = Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Введите количетсво крон: ");
                        countSek = Convert.ToInt32(Console.ReadLine());
                        yourBalanceInSek += countSek;
                        yourBalanceInRub -= countSek * sekRub;
                        Console.WriteLine($"Количество шведских крон на счёте: {yourBalanceInSek}");
                        Console.WriteLine($"Количество рублей на счёте: {yourBalanceInRub}");
                        Console.Write("Желаете закончить/продолжить? ");
                        proceed = Console.ReadLine();
                        break;
                    case "6":
                        Console.Write("Введите количетсво крон: ");
                        countSek = Convert.ToInt32(Console.ReadLine());
                        yourBalanceInSek += countSek;
                        yourBalanceInUsd -= countSek * sekUsd;
                        Console.WriteLine($"Количество шведских на счёте: {yourBalanceInSek}");
                        Console.WriteLine($"Количество долларов на счёте: {yourBalanceInUsd}");
                        Console.Write("Желаете закончитьпродолжить? ");
                        proceed = Console.ReadLine();
                        break;
                    case "7":
                        proceed = exit;
                        break;
                }
            }

            Console.WriteLine("Баланс рублей " + yourBalanceInRub);
            Console.WriteLine("Баланс шведсих крон " + yourBalanceInSek);
            Console.WriteLine("Баланс долларов " + yourBalanceInUsd);
        }
    }
}
