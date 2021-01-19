using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Smirnov.ThreadLocker_3_
{
    static public class ThreadLocker
    {
        static object locker = new object();
        static object locker2 = new object();
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] result = new int[10];
        public static void LolMain()
        {
            Thread thread1 = new Thread(FillArray);
            Thread thread2 = new Thread(SumTwoArray);
            thread1.Start();
            thread2.Start();
            static void FillArray()
            {
                lock (locker)
                {
                    Random rnd = new Random();
                    Console.Write("First array: ");
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = rnd.Next(-100, 100);
                        Console.Write(array1[i] + " ");
                    }
                    Console.WriteLine();
                }
                lock (locker)
                {
                    Random rnd = new Random();
                    Console.Write("Second array: ");
                    for (int i = 0; i < array2.Length; i++)
                    {
                        array2[i] = rnd.Next(-100, 100);
                        Console.Write(array2[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void SumTwoArray()
            {
                Thread.Sleep(100);
                Console.Write("Result array: ");
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = array1[i] + array2[i];
                    Console.Write(result[i] + " ");
                }
            }
        }
    }
}
