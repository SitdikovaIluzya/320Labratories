using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov.Thread
{
    class ThreeMethods
    {
        public static int[] numbers = { 3, 5 , 7, 2, 2, 9 };

        public static void Sum(object obj)
        {
            int[] arr = obj as int[];
            arr = numbers;
            int sum = 0; 
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Сумма всех чисел: " + sum);
        }

        public static void Max(object obj)
        {
            int[] arr = obj as int[];
            arr = numbers;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Максимальное число: " + max);
        }

        public static void Sort(object obj)
        {
            int[] arr = obj as int[];
            arr = numbers;
            int element = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        element = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = element;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
