using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Musin.Threading
{
    class ThreadStart
    {
        public static void Start()
        {
            int[] array = { 1, 3, 4, 6, 2, 8, 9, 11 };
            Thread thread1 = new Thread(Summ);
            Thread thread2 = new Thread(Max);
            Thread thread3 = new Thread(Sort);
            thread1.Start(array);
            thread2.Start(array);
            thread3.Start(array);
        }

        public static void Summ(object obj)
        {
            int[] arr = (int[]) obj;
            int summ = 0;
            foreach (int item in arr)
            {
                summ += item;
            }
            Console.WriteLine("Summ of elements: " + summ);
        }

        public static void Max(object obj)
        {
            int[] arr = (int[]) obj;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max element: " + max);
        }

        public static void Sort(object obj)
        {
            int[] arr = (int[]) obj;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
