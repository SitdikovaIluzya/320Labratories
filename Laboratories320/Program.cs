using System;
using System.Threading;

namespace Laboratories320
{
    class Program
    {
        static int[] array_1 = new int[10];
        static int[] array_2 = new int[10];
        static int[] array_3 = new int[10];
        static object locker = new object();
        static void Main(string[] args)
        {

        }

        static void Random_Ar()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for(int i = 0; i < 10; i++)
                {
                    array_1[i] = rnd.Next();
                    array_2[i] = rnd.Next();
                }
            }
        }

    }
}
