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
        }

        public static void AddItemsInCollection(string[] items, List<string> mergeColection)
        {
            mergeColection.AddRange(items);
            mergeColection.Sort();
           
            for (int i = 0; i < mergeColection.Count; i++)
            {
                string item;
                item = mergeColection[i];
                int indexItem;
                indexItem = mergeColection.LastIndexOf(item);

                if (mergeColection[i].Equals(mergeColection[indexItem]))
                {
                    mergeColection.RemoveAt(indexItem);
                    i++;
                }
            }
        }
    }
}
