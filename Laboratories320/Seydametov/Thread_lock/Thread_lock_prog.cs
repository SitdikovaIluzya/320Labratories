using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Laboratories320.Seydametov.Threading
{
    class Thread_lock_prog
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] sum = new int[10];

        static object locker = new object();
        public static void Thread_lock_Main()
        {
            
            Thread threadRan = new Thread(Random);
            threadRan.Start();
            Thread.Sleep(10);
            Thread threadSum = new Thread(Sum);
            threadSum.Start();
            Thread.Sleep(100);
            lock (locker)
            {
                for (int y = 0; y < arr1.Length; y++)
                {
                    Console.WriteLine("1 массив " + arr1[y]);
                    Console.WriteLine("2 массив " + arr2[y]);
                    Console.WriteLine("Sum " + sum[y]);
                }
            }
        }

        public static void Random(object obj)
        {

            Random rand = new Random();
            for (int y = 0; y < arr1.Length; y++)
            {
                arr1[y] = rand.Next(1, 20);
                arr2[y] = rand.Next(1, 20);
              
            }
        }

        public static void Sum(object obj)
        {
            
            lock (locker)
            {
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = arr1[i] + arr2[i];
                    
                }  
            }
        }


}
}
