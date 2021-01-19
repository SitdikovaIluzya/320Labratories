using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Tikhonov.Locker
{
    class Thread_locking
    {
        private static int[] FirstArray = new int[10];
        private static int[] SecondArray = new int[10];
        private static int[] FinalArray = new int[10];
        public static void Threads()
        {
            ArrObj Arrays = new ArrObj(FirstArray, SecondArray);
            Thread threadSum = new Thread(sumOfElements);
            Thread threadGen = new Thread(arrGen);
            threadSum.Start(Arrays);
            threadGen.Start(Arrays);

        }
        private static void sumOfElements(Object obj)
        {
            
        }

      
        private static void arrGen(object obj)
        {
            Random rand = new Random();
            for (int i = 0; i < FirstArray.Length; i++)
            {
                FirstArray[i] = rand.Next(10);
                SecondArray[i] = rand.Next(10);
            }

        }
    }
}
