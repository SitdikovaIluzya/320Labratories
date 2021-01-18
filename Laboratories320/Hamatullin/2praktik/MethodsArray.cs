using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._2praktik
{
    class MethodsArray
    {
        private int[] array;
        public int[] Array { get; set; }
        public MethodsArray(int[] Array)
        {
            this.Array = Array;
        }
        public void Summa(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            Console.WriteLine($"Сумма чисел в массиве: {sum}");
        }
        public void MaxElem()
        {
            int max = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if(max < Array[i])
                {
                    max = Array[i];
                }
            }
            Console.WriteLine($"Максимальный элемент в массиве: {max}");
        }
        public void SortArray()
        {
            int a = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        a = Array[i];
                        Array[i] = Array[j];
                        Array[j] = a;

                    }
                }
            }
        }
    }
}
