using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Sindryakov.ThreadLocker
{
    class Locker
    {
            // начало выполнения 3 практики
            //int[] numbers1 = { 3, 4, 45, 29, 2, 23, 48, 33, 1, 54 };
            //int[] numbers2 = { 8, 4, 13, 16, 2, 15, 48, 33, 5, 52 };
            //int[] numbers3 = { 8, 4, 13, 16, 2, 15, 48, 33, 5, 43 };

            static int[] outcome = new int[10];
            static int[] numbers1 = new int[10];
            static int[] numbers2 = new int[10];

            static object locker = new object();

        //Thread thr1 = new Thread(Summ);
        //Thread thr2 = new Thread(Generate);

        //lock - написать

        //thr2.Start(numbers2);
        public static void GoOff()
        {
            Thread thr1 = new Thread(Transform);
            Thread thr2 = new Thread(TotalSum);
            thr1.Start(numbers1);
            thr2.Start(numbers2);
        }
        public static void TotalSum(object obj)
        {

            int[] nums1 = (int[])obj;
            int sum1 = 0;
            foreach (int value in nums1)
            {
                sum1 += value;
            }

            int[] nums2 = (int[])obj;
            int sum2 = 0;
            foreach (int value in nums2)
            {
                sum2 += value;
            }
            int sum = sum1 + sum2;
            Console.WriteLine("Сумма элементов массива:" + sum);
        }
        public static void Transform(object obj)
        {
            Console.WriteLine("Генерация: ");
        }
    }
}
