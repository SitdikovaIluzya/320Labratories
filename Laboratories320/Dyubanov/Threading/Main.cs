using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Dyubanov.Threading
{
    class Main
    {
        public void Thread1()
        {
            int[] array = new int[10] { 4, 56, 34, 5, 6, 5, 3, 453, 6, 32 };
            Thread thread1 = new Thread(sumOfElement);
            Thread thread2 = new Thread(maxElement);
            Thread thread3 = new Thread(sort);
            thread1.Start(array);
            thread2.Start(array);
            thread3.Start(array);
            array[0] = 1;
        }

        private void sumOfElement(object obj)
        {
            double sum = 0;
            int[] arr = (int[])obj;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i] + sum;
            }
            Console.WriteLine("Sum = " + sum);
        }

        private void maxElement(object obj)
        {
            int[] arr = (int[])obj;
            int max = arr[0];
            for (int i = 1; i < arr.Length; ++i)
                if (arr[i] > max) max = arr[i];
            Console.WriteLine("Max = " + max);
        }

        private void sort(object obj)
        {
            Array.Sort((int[])obj);
            int[] arr = (int[])obj;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + " arr element = " + arr[i]);
            }
        }
    }
}
