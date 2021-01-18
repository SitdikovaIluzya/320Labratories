using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;


namespace Laboratories320.Kiyamov.Threaddd
{
    class ThreadM
    {

        public static int[] array = { 0, 6, 1, 5, 15, 2, -29, -66, 2, 22, 6 };
        public static void Start()
        {
            var thr1 = new Thread(Sum);
            var thr2 = new Thread(Max);
            var thr3 = new Thread(Sorting);
            thr1.Start();
            thr2.Start();
            thr3.Start();


            static void Sum()
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine("Сумма:" + sum);
            }
            static void Max()
            {

                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine("Max: " + max);
            }
            void Sorting()
            {
                Array.Sort(array);
                Console.Write("Отсортированный массив");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}