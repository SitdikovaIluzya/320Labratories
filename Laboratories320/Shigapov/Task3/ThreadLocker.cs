using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Shigapov.Task3
{
    class ThreadLocker
    {
        public static int[] array1 = new int[10];
        public static int[] array2 = new int[10];
        public static int[] array3 = new int[10];
        static object locker = new object();

        public void BaseThread()
        {
            Thread thread1 = new Thread(new ParameterizedThreadStart(Rnd));
            Thread thread2 = new Thread(new ThreadStart());
        } 

        public static void Sum()
        {

                for (int i = 0; i < 0; i++)
                {
                    array3[i] = array1[i]+array2[i];
                }
        }


        public void Rnd(object obj)
        {
            lock (locker)
            {
                int[] array = (int[])obj;
                Random rnd = new Random();
                for (int i = 0; i < 0; i++)
                {
                    array[i] = rnd.Next(-10, 10);
                }

            }
        }

    }
}
