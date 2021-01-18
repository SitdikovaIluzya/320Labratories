using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Laboratories320.Abdrakov.Threads
{
    class ThreadingStart
    {
        public void PseudoMain()
        {
            int[] array = { 800, -11, 50, -771, 649, 770, 240, -9 };

            Thread threadSort = new Thread(() => { Sort(array); });
            threadSort.Start();
            Thread threadMax = new Thread(() => { MaxValue(array); });
            threadMax.Start();
            Thread threadSum = new Thread(() => { SumArray(array); });
            threadSum.Start();
        }

        public void Sort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public void MaxValue(int[] arr)
        {
            Console.WriteLine(arr.Max());
        }

        public void SumArray(int[] arr)
        {
            Console.WriteLine(arr.Sum());
        }
    }
}
