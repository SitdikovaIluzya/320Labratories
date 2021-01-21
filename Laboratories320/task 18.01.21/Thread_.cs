using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.task_18._01._21
{
    class Thread_
    {
        static int[] array = { 1, 2, 3, 4, 6, 7, 8, 9, 0 };
        static void ThreadMain()
        {
            Thread t1 = new Thread(Max);
            Thread t2 = new Thread(Sum);
            Thread t3 = new Thread(Sort);
            t1.Start();
            t2.Start();
            t3.Start();
        }

        static void Max()
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Максимум " + max);
            Thread.Sleep(500);
        }

        static void Sum()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("Сумма " + sum);
            Thread.Sleep(500);
        }

        static void Sort()
        {
            Array.Sort(array);
            Console.WriteLine(String.Join(" ", array));
            Thread.Sleep(500);
        }
    }
}
