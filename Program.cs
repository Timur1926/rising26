using System;
using System.Collections.Generic;

namespace ExplanatoryDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Тольковый словарь *****");
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            keyValuePairs.Add("ассигнация", "бумажный денежный знак в России (с 1769 г. по 1843 г.)");
            keyValuePairs.Add("маржа", "разница между ценой и себестоимостью (аналог понятия прибыль)");
            keyValuePairs.Add("опцион", "это один из производных финансовых инструментов");
            keyValuePairs.Add("инфляция", "устойчивое повышение общего уровня цен на товары и услуги");
            keyValuePairs.Add("дэфолт", "(англ. default — невыполнение обязательств) — невыполнение договора займа");
            keyValuePairs.Add("девальвация", "снижения курса национальной валюты по отношению к твёрдым валютам в системах с фиксированным курсом валюты, устанавливаемым денежными властями");
            keyValuePairs.Add("деноминация", "изменение (а точнее уменьшение численного масштаба) номинальной (нарицательной) стоимости денежных знаков");

            Console.WriteLine("=> Список слов в словаре");

            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine($"-> {keyValue.Key}");
            }

            Console.Write("Введи слово из списка, значение которого ты хочеш узнать: ");
            string userRequest = Console.ReadLine().ToLower();

            if (keyValuePairs.ContainsKey(userRequest))
            {
                Console.WriteLine($"{userRequest} - {keyValuePairs[userRequest]}");
            }
            else
            {
                Console.WriteLine("ERROR!!! Такого значения в списке словаря нет!!!");
            }
        }
    }
}
