using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Lab2
{
    static class Threading
    {
        public static Thread SumThread = new Thread(Sum);
        public static Thread MaxThread = new Thread(Max);
        public static Thread SortThread = new Thread(Sort);
        static void Sum()
        {
            int[] array = { 1, 15, 290, 45, 4, 1, 2, 8, 43 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            Thread.Sleep(100);
        }

        static void Max()
        {
            int[] array = { 1, 15, 290, 45, 4, 1, 2, 8, 43 };
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Thread.Sleep(200);
        }

        static void Sort()
        {
            int[] array = { 1, 15, 290, 45, 4, 1, 2, 8, 43 };
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
            Thread.Sleep(300);
        }
    }
}
