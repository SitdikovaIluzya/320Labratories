using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Hamatullin._5praktik
{
    class ContinuationTasks
    {
        static int[] mass = new int[20];
        static int product = 1;

        public static void Start()
        {
            Task task1 = new Task(Gen);
            Task task2 = new Task(GetProduct);
            Task task3 = task2.ContinueWith(digits => GetDigits());
            task1.Start();
            task2.Start();
            task3.Wait();
        }

        public static void Gen()
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(1, 4);
            }
        }
        public static void GetProduct()
        {
            Thread.Sleep(10);
            foreach (var item in mass)
            {
                product *= item;
            }
            Console.WriteLine(product);
        }
        public static void GetDigits()
        {
            while (product > 10)
            {
                if (product % 2 == 0)
                {
                    string proiz = product.ToString();
                    Console.Write(proiz[proiz.Length - 1] + " ");
                }
                product /= 10;
            }
            if (product % 2 == 0)
            {
                Console.Write(product);
            }
        }
    }
}
