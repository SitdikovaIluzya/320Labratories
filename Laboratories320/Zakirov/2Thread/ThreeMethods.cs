using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._2Thread
{
    class ThreeMethods
    {
        public static int[] numbers = { 3, 5 , 7, 2, 2, 9 };

        public static void Sum(object obj)
        {
            int[] arr = obj as int[];
            arr = numbers;
            int sum = 0; 
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма всех чисел: " + sum);
        }

        public static void Max(object obj)
        {
            int[] arr = obj as int[];
            arr = numbers;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Максимальное число: " + max);
        }

        public static void Sort(object obj)
        {
            int[] arr = obj as int[];
            arr = numbers;
            int element = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        element = arr[i];
                        arr[i] = arr[j];
                        arr[j] = element;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
