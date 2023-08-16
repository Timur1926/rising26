﻿using System;
using System.Collections.Generic;

namespace MergeIntoOneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = new string[] { "1", "2", "1" };
            string[] string2 = new string[] { "1", "2", "3" };

            List<string> mergeColection = new List<string>();

            for (int i = 0; i < string1.Length; i++)
            {
                mergeColection.Add(string1[i]);
                mergeColection.Add(string2[i]);
                mergeColection.Sort();
            }

            Console.WriteLine("Объединённая, сортированная коллекция");

            for (int i = 0; i < mergeColection.Count; i++)
            {
                int numberItem;
                numberItem = mergeColection.BinarySearch(mergeColection[i]);
                mergeColection.RemoveAt(numberItem);

                Console.Write(mergeColection[i] + " | ");
            }

            Console.WriteLine();
        }
    }
}
