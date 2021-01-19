using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Sindryakov.ThreadLocker
{
    class Locker
    {
        public static void Start()
        {
            // начало выполнения 3 практики
            int[] numbers1 = { 3, 4, 45, 29, 2, 23, 48, 33, 1, 54 };
            int[] numbers2 = { 8, 4, 13, 16, 2, 15, 48, 33, 5, 52 };
            //int[] numbers3 = { 8, 4, 13, 16, 2, 15, 48, 33, 5, 43 };

            Thread thr1 = new Thread(Summ);
            Thread thr2 = new Thread(Generate);

            //lock - написать

            thr2.Start(numbers2);
        }
        public static void Summ(object obj)
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
        public static void Generate(object obj)
        {
            Console.WriteLine("Генерация: ");
        }
    }
}
