using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Program
    {
        static int[] array = new int[20];
        static int prod = 1;
        static void Main(string[] args)
        {
            Task task1 = new Task(() => Random_Ar());
            task1.Start();
            Task task2 = task1.ContinueWith(Product);
            task2.Wait();
            Task task3 = task2.ContinueWith(EvenDigits);
            task3.Wait();
        }

        static void Random_Ar()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 5);
            }
            Console.WriteLine("Массив = " + String.Join(", ", array));
        }

        static void Product(Task t)
        {
            for (int i = 0; i < 20; i++)
            {
                prod *= array[i];
            }
            Console.WriteLine("Произведение = " + prod);
            Thread.Sleep(1000);
        }

        static void EvenDigits(Task t)
        {
            char[] chars = prod.ToString().ToCharArray();
            List<int> result = new List<int> { };
            foreach (var item in chars)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    result.Add(Convert.ToInt32(item));
                }
            }
            Console.WriteLine("Цифры = " + String.Join(", ", result));
        }

    }
}
