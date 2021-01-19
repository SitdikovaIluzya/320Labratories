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
            lock(locker)
            {
                thread1.Start();
            }
            thread2.Start();
        }
        public static void Generate()
        {
            Random rnd = new Random();
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(10);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(10);
            }
        }
        
        public static void Summ()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
        }

    }
}
