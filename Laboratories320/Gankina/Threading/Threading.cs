using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Gankina.Threading
{
    class Threading
    {
        public static Thread SumThread = new Thread(Sum);
        public static Thread MaxThread = new Thread(Max);
        public static Thread SortThread = new Thread(Sort);
        
       

        static void Sort()
        {
            int[] array = { 100, 150, 290, 56, 4, 89, 2, 8, 430 };
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        temp = array[i];
                        array[i] = array[k];
                        array[k] = temp;
                    }
                }
            }
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
            Thread.Sleep(100);
        }
        static void Sum()
        {
            int[] array = { 2, 25, 555, 45, 5, 1, 3, 8, 55, 105, 188, 166 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            Thread.Sleep(500);
        }
        static void Max()
        {
            int[] array = { 5, 25, 88, 66, 5, 10, 20, 888, 430 };
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Thread.Sleep(105);
        }
    }
}

