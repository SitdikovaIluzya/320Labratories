using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Volkov.ThreadLocker
{
    public class ThreadLocker
    {
        public static int[] arr1 = new int[10];
        public static int[] arr2 = new int[10];
        public static int[] res = new int[10];
        static object locker = new Object();

        static void FillingArr()
        {
            lock(locker)
            {
                Random rnd = new Random();
                Console.WriteLine("First array:");
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = rnd.Next(-100, 1000);
                    Console.Write(arr1[i] + "; ");
                }
                Console.WriteLine();
                Console.WriteLine("Second array: ");
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = rnd.Next(-100, 1000);
                    Console.Write(arr2[i] + "; ");
                }
                Console.WriteLine();
            }
        }

        static void SumArray()
        {
            Thread.Sleep(50);
            
            {
                Console.WriteLine("Result array: ");
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = arr1[i] + arr2[i];
                    Console.Write(res[i] + "; ");
                }
                Console.WriteLine();
            }
        }

        public static void Work()
        {
            Thread fillarr = new Thread(FillingArr);
            fillarr.Start();

            Thread sumarr = new Thread(SumArray);
            
            sumarr.Start();
            
        }

    }
}
