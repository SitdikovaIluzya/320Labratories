using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Practic_3
{
    class Massiv
    {
       
            public static int[] array1 = new int[10];
            public static int[] array2 = new int[10];
            public static int[] array3 = new int[10];

            static object Sum = new object();
            static object Result = new object();

            public static void BaseThread()
            {
                Massiv thread1 = new Massiv(new ThreadStart(Rnd));
                Massiv thread2 = new Massiv(new ThreadStart(Summ));
                thread1.Start();
                Thread.Sleep(10);
                thread2.Start();
                Console.WriteLine("[{0}]", string.Join(", ", array1));
                Console.WriteLine("[{0}]", string.Join(", ", array2));
                Console.WriteLine("[{0}]", string.Join(", ", array3));
            }

    }
}
