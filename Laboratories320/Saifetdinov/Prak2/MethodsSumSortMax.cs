using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.Prak2
{
    class MethodsSumSortMax
    {
        public static void Summa(object obj)
        {
            int summa = 0;
            int[] array = obj as int[];
            array = ElementsArray.array1;
            for (int i = 0; i < array.Length; i++)
            {
                summa = summa + array[i];
            }
            Console.WriteLine($"Sum elements array = {summa}");
        }

        public static void MaxElementArray(object obj)
        {
            int max = 0;
            int[] array = obj as int[];
            array = ElementsArray.array2;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Max element array = {max}");
        }

        public static void SortElemntsArray(object obj)
        {
            int newarr = 0;
            int[] array = obj as int[];
            array = ElementsArray.array3;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        newarr = array[i];
                        array[i] = array[j];
                        array[j] = newarr;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Sort element array ={array[i]}");
            }
        }
    }
}
