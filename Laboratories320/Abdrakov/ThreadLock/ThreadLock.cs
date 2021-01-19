using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Abdrakov.ThreadLock
{
    class ThreadLock
    {
        private static int[] array1 = new int[10];
        private static int[] array2 = new int[10];
        private static int[] arrayOut = new int[10];

        private static object arrayLock = new object();
        private static object resultLock = new object();

        private static Random random = new Random();

        public static void PseudoMain()
        {
            Thread threadSort = new Thread(() => { GenerateArrays(); });
            threadSort.Start();
            Thread threadMax = new Thread(() => { FindEachSum(); });
            threadMax.Start();
            lock (resultLock)
            {
                Console.WriteLine(array1);
                Console.WriteLine(array2);
                Console.WriteLine(arrayOut);
            }
        }

        private static void GenerateArrays()
        {
            for (int i = 0; i < 10; ++i)
            {
                lock (arrayLock)
                {
                    array1[i] = random.Next(-50, 50);
                    array2[i] = random.Next(-50, 50);
                }
            }
            Console.WriteLine("Generating finished");
        }

        private static void FindEachSum()
        {
            lock (resultLock)
            {
                for (int i = 0; i < 10; ++i)
                {
                    lock (arrayLock)
                    {
                        arrayOut[i] = array1[i] + array2[i];
                    }
                }
                Console.WriteLine("Finding each sum finished");
            }
        }
    }
}
