using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.task_19._01._21
{
    class ThreadLock
    {
        static int[] array_1 = new int[10];
        static int[] array_2 = new int[10];
        static int[] array_3 = new int[10];
        static object locker = new object();
        static void Main()
        {
            Thread th1 = new Thread(Random_Ar);
            Thread th2 = new Thread(Sum);
            th1.Start();
            th2.Start();
        }

        static void Random_Ar()
        {
            lock (locker)
            {
                Console.WriteLine("Поток 1");
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array_1[i] = rnd.Next(10);
                    array_2[i] = rnd.Next(10);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(array_1[i] + ", " + array_2[i]);
                }
            }
        }

        static void Sum()
        {
            Console.WriteLine("Поток 2");
            for (int i = 0; i < 10; i++)
            {
                array_3[i] = array_1[i] + array_2[i];
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array_3[i]);
            }
        }
    }
}
