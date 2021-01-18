﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Mazitova.Thread
{
    class Threading
    {
        // 1.1 
        static void Sum()
        {
            int[] array = new int [10];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                sum += array[i];
            }
            Console.WriteLine(sum);
            Threading.Sleep(10);
        }

        //2.2
        static void Max()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Threading.Sleep(10);
        }
        //3.3
        static void Sort()
        {
            int[] array = new int[10];
            Random rnd = new Random();
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
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
            Threading.Sleep(10);
        }
    }
}


