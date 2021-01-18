using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._2praktik
{
    static class MethodsArray
    {
        public static void Summa(object obj)
        {
            int[] Array = obj as int[];
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            Console.WriteLine($"Сумма чисел в массиве: {sum}");
        }
        public static void MaxElem(object obj)
        {
            int[] Array = obj as int[];
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
        public static void SortArray(object obj)
        {
            int[] Array = obj as int[];
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
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
    }
}
