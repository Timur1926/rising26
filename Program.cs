using System;
using System.Collections.Generic;

namespace MergeIntoOneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings1 = new string[] { "1", "2", "1" };
            string[] strings2 = new string[] { "1", "2", "3" };

            List<string> mergeColection = new List<string>();

            AddItemsInCollection(strings1, mergeColection);
            AddItemsInCollection(strings2, mergeColection);
            ShowDisplay(mergeColection);
        }

        public static void AddItemsInCollection(string[] items, List<string> mergeColection)
        {

            for (int i = 0; i < items.Length; i++)
            {
                string item = items[i];

                if (mergeColection.Contains(item)) 
                { }
                else
                {
                    mergeColection.Add(item);
                }
            }

            mergeColection.Sort();
        }

        public static void ShowDisplay(List<string> colection)
        {
            Console.Write("Объединённая коллекци: ");

            for (int i = 0; i < colection.Count; i++)
            {
                Console.Write($"{colection[i]} ");
            }

            Console.WriteLine();
        }
    }
}
