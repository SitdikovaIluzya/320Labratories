using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Musin.ThreadLocker
{
    class Locker
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] result = new int[10];
        static object locker = new object();

        public static void Start()
        {
            Thread thread1 = new Thread(Generate);
            Thread thread2 = new Thread(Summ);
            thread1.Start();
            thread2.Start();
        }
        public static void Generate()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(10);
                    Console.Write(array1[i] + " ");
                }

                Console.WriteLine();

                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rnd.Next(10);
                    Console.Write(array1[i] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public static void Summ()
        {
            Thread.Sleep(100);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] + array2[i];
                Console.Write(result[i] + " ");
            }
        }

    }
}
