using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;


namespace Laboratories320.Kiyamov.Thread
{
    class Thread
    {

        public int[] array;

        public int[] intArray { get => array; set => array = value; }

        void SumArray()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine("Сумма" + sum);
        }

        public void MaxElement()
        { 
        int max = 0;
            int i;
            for (i = 1; i < array; i++)
            {
                if (a[i] < 5 && a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("max = {0}", max);
        }
        

        public void Sorting()
        {
            Array.Sort(array);
            Console.WriteLine("Отсортированный элемент:  ");
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }
        }


    }
}
