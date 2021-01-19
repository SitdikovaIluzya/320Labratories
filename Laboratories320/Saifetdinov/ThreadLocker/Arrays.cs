using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.ThreadLocker
{
    class Arrays
    {
        public static void Thread()
        {
            Thread thread1 = new Thread(Gen);
        }
        public static void Gen()
        {
            int[] array = new int[9];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
                Console.Write(array[i] + " ");
            }
        }
    }
}
