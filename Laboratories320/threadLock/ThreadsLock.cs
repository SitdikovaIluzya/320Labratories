using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.threadLock
{
    class ThreadsLock
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] arr3 = new int[10];
        static object locker = new object();
        static void MainTwo()
        {

            Thread th1 = new Thread(Random_Ar);
            th1.Start();
            Thread th2 = new Thread(Sum);
            th2.Start();

        }
        static void Random_Ar()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    arr1[i] = rnd.Next(10);
                    arr2[i] = rnd.Next(10);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr1[i] + "," + arr2[i]);
                }
            }
        }

        static void Sum()
        {
            for (int i = 0; i < 10; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}

