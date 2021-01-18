using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Laboratories320.Seydametov.Threading
{
    class Class1
    {
        public static void Main()
        {
            int[] array = { 525, 26, -65, 752, -58, 634, -78, 3 };

            Thread threadSum = new Thread(SumArray);
            threadSum.Start(array);
            Thread threadMax = new Thread(MaxValue);
            threadMax.Start(array);
            Thread threadSort = new Thread(SortArray);
            threadSort.Start(array);
        }


        // Сумма чисел
        public static void SumArray(object obj)
        {
            int[] arr = (int[])obj;
            Console.WriteLine(arr.Sum());
        }



        // Максимальное значение
        public static void MaxValue(object obj)
        {
            int[] arr = (int[])obj;
            Console.WriteLine(arr.Max());
        }



        // Сортировка массива 
        public static void SortArray(object obj1)
        {
            int[] arr = (int[])obj1;
            int temp1 = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp1 = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp1;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

      

        
    }
}