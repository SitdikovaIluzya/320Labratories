using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Zakirov._3ThreadLocker
{
    class ThreadLock
    {
        static object locker = new object();
        static int[] numbers1 = new int[10];
        static int[] numbers2 = new int[10];
        static int[] result = new int[10];

        public static void StartingThread()
        {
            Thread thread1 = new Thread(Generator);
            Thread thread2 = new Thread(Sum);
            thread1.Start();
            thread2.Start();
        }

        public static void Generator()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < numbers1.Length; i++)
                {
                    numbers1[i] = rnd.Next(1, 9);
                    Console.Write(numbers1[i] + " ");
                }

                Console.WriteLine();

                for (int i = 0; i < numbers2.Length; i++)
                {
                    numbers2[i] = rnd.Next(1, 9);
                    Console.Write(numbers2[i] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Sum()
        {
            Thread.Sleep(100);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numbers1[i] + numbers2[i];
                Console.Write(result[i] + " ");
            }
        }
    }
}
