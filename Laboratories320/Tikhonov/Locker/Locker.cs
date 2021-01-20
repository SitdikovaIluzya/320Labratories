using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Tikhonov.Locker
{
    class Thread_locking
    {
        static Object locker1 = new Object();


        private static int[] FirstArray = new int[10];
        private static int[] SecondArray = new int[10];
        private static int[] FinalArray = new int[10];
        public static void Threads()
        {
            ArrObj Arrays = new ArrObj(FirstArray, SecondArray);
            Thread threadGen = new Thread(arrGen);
            Thread threadSum = new Thread(sumOfElements);
            threadGen.Start(Arrays);
            Thread.Sleep(100);
            threadSum.Start(Arrays);
        }
        private static void sumOfElements(Object obj)
        {
            lock (locker1)
            {
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    FinalArray[i] = FirstArray[i] + SecondArray[i];
                }
                Console.WriteLine("[{0}]", string.Join(", ", FinalArray));
            }
        }

        private static void arrGen(object obj)
        {
            Random rand = new Random();
            lock(locker1)
            {
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    FirstArray[i] = rand.Next(10);
                    SecondArray[i] = rand.Next(10);
                }
                Console.WriteLine("[{0}]", string.Join(", ", FirstArray));
                Console.WriteLine("[{0}]", string.Join(", ", SecondArray));


                }
            }
    }
}
