using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Hamatullin._3praktik
{
    class ManyThread
    {
        static Object locker = new object();
        static int[] mass1 = new int[10];
        static int[] mass2 = new int[10];
        static int[] result = new int[10];

        public static void StartThread()
        {
            Thread thread1 = new Thread(GenerateMass);
            Thread thread2 = new Thread(Sum);
            thread1.Start();
            thread2.Start();
        }

        public static void GenerateMass()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < mass1.Length; i++)
                {
                    mass1[i] = rnd.Next(10, 20);
                    mass2[i] = rnd.Next(10, 20);
                }
            }
        }
        public static void Sum()
        {
            Thread.Sleep(10);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = mass1[i] + mass2[i];
                Console.Write(result[i] + " ");
            }
        }

    }

    
}
