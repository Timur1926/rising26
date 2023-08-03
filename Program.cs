using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAtStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> check = new Queue<int>();
            Queue<string> client = new Queue<string>();
            int storeAccount = 0;
            int emptyQueue = 0;
            int clientNumber = 0;
            check.Enqueue(10);
            check.Enqueue(20);
            check.Enqueue(30);
            check.Enqueue(40);
            check.Enqueue(50);
            check.Enqueue(60);
            check.Enqueue(70);
            check.Enqueue(80);

            while (check.Count > emptyQueue)
            {
                Console.Clear();
                storeAccount += check.Dequeue();
                clientNumber++;
                Console.WriteLine($"Клиент #{clientNumber}");
                Console.WriteLine($"Счёт магазина: {storeAccount}");
                Console.ReadKey();
            }

        }
    }
}
