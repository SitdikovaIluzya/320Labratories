using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Lab2
{
    class Threading
    {
        public int[] Array { get; set; }

        public Threading(int[] array)
        {
            this.Array = array;
        }

        public void Start()
        {
            Thread SumThr = new Thread(Sum);
            Thread MaxThr = new Thread(Max);
            Thread SortThr = new Thread(Sort);
            SumThr.Start();
            Thread.Sleep(100);
            MaxThr.Start();
            Thread.Sleep(100);
            SortThr.Start();


        }
        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            Console.WriteLine("Сумма элементов массива" + " " + sum);
        }

        public void Max()
        {
            int max = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива" + " " + max);
        }

        public void Sort()
        {
            int temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив");
            foreach (var a in Array)
            {
                Console.WriteLine(a + " ");
            }
        }


    }
}
