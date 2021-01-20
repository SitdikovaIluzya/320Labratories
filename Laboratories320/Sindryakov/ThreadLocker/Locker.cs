using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Sindryakov.ThreadLocker
{
    class Locker
    {
        //3 практика
        static int[] outcome = new int[10];
        static int[] numbers1 = new int[10];
        static int[] numbers2 = new int[10];

        static object locker = new object();


        //lock - написать

        public static void GoOff()
        {
            Thread thr1 = new Thread(Transform);
            Thread thr2 = new Thread(TotalSum);
            thr1.Start(numbers1);
            thr2.Start(numbers2);
        }
        public static void TotalSum()
        {
            Thread.Sleep(100);
            for (int i = 0; i < outcome.Length; i++)
            {
            }
            Console.WriteLine("Сумма элементов массива:" + sum);
        }
        public static void Transform(object obj)
        {
            lock (locker)
            {
                Console.WriteLine("Генерирование значений - ");
            }
        }
    }
}
