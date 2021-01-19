using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Lab2
{
    class Threading
    {

        int[] array;

        public int[] Array { get => array; set => array = value; }

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
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Сумма элементов массива" + " " + sum);
        }

        public void Max()
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива" + " " + max);
        }

        public void Sort()
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив");
            foreach (var a in array)
            {
                Console.WriteLine(a + " ");
            }
        }


    }
}
