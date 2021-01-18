using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Smirnov.ThreadStart_2_
{
    public class ThreadCustom
    {
        static int[] array = { 2, 51, 73, 6, 3, 17, 7, 3 };
        static public void Start()
        {
            Thread threadSum = new Thread(SumInArray);
            Thread threadMax = new Thread(MaxInArray);
            Thread threadSort = new Thread(SortInArray);
            threadSum.Start();
            threadMax.Start();
            threadSort.Start();
            static void SumInArray()
            {
                int sum = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine("Sum" + sum);
            }
            static void MaxInArray()
            {
                int max = -2147483648;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]>max)
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine("Max" + max);
            }
            static void SortInArray()
            {
                Array.Sort(array);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
                
            }
        }
    }
}
