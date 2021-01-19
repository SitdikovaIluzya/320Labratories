using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Dyubanov.Threading
{
    class Locker
    {
        static int[] arrA = new int[10];
        static int[] arrB = new int[10];
        static int[] arrSum = new int[10];

        static object locker = new object();

        public void Start()
        {
            Thread Build = new Thread(build_array);
            Thread Sum = new Thread(sum_array);
            Build.Start();
            Thread.Sleep(50);
            Sum.Start();
            Thread.Sleep(50);
            lock (locker)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1 + " A = " + arrA[i]);
                    Console.WriteLine(i + " B = " + arrB[i]);
                    Console.WriteLine(i + " Sum = " + arrSum[i]);
                }
            }
        }

        private void build_array()
        {
                for (int i = 0; i < arrA.Length; i++)
                {
                    Random rnd = new Random();
                    arrA[i] = rnd.Next(0, 100);
                arrB[i] = rnd.Next(0, 100);
            }  
        }

        private void sum_array()
        {
            lock (locker)
            {

                for (int i = 0; i < arrSum.Length; i++)
                {
                    arrSum[i] = arrA[i] + arrB[i];
                }
            }
        }
    }
}
