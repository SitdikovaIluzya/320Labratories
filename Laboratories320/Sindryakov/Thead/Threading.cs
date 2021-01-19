using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Laboratories320.Sindryakov.Thead
{
    class Threading
    {
        public static void Start()
        {
            int[] numbers = { 10, 4, 13, 29, 2, 15, 48, 33, 1 };

            Thread thr1 = new Thread(TotalSum);
            Thread thr2 = new Thread(Max);
            Thread thr3 = new Thread(Sort);

            thr1.Start(numbers);
            thr2.Start(numbers);
            thr3.Start(numbers);
        }

        public static void TotalSum(object obj)
        {
            int[] nums = (int[])obj;
            int sum = 0;
            foreach (int value in nums)
            {
                sum += value;
            }
            Console.WriteLine("Сумма элементов массива: " + sum);
        }

        public static void Max(object obj)
        {
            int[] nums = (int[])obj;
            int maxValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                {
                    maxValue = nums[i];
                }
            }
            Console.WriteLine("Максимальный элемент в массиве " + maxValue);
        }

        public static void Sort(object obj)
        {
            int[] nums = (int[])obj;
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("Массив отсортирован по возрастанию");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
