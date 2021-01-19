using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace Laboratories320.Tikhonov.Threading
{
    class main
    {
        private static int[] array = new int[10] { 4, 2, 41, 5, 15, 73, 13, 6, 32, 123 };
        public static void Threads()
        {
            
            Thread threadSum = new Thread(sumOfElement);
            Thread threadMaxElement = new Thread(maxElement);
            Thread threadSort = new Thread(sort);
            threadSum.Start(array);
            threadMaxElement.Start(array);
            threadSort.Start(array);
            array[0] = 1;
        }
        private static void sumOfElement(object obj)
        {
            double sum = 0;
            int[] arr = (int[])obj;
            sum = arr.Sum();
            Console.WriteLine("Sum = " + sum);
        }

        private static void maxElement(object obj)
        {
            int[] arr = (int[])obj;
            int max = arr.Max();
            Console.WriteLine("Max = " + max);
        }

        private static void sort(object obj)
        {
            Array.Sort((int[])obj); 
            int[] arr = (int[])obj;
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }
}
