using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Volkov.SecondPractice
{
    public class SecondPractice
    {
        public static int[] array = new int[5] {321, 2312, 3123, 222, 0 };
        
        
        public static void Start()
        {
            Thread SumThread = new Thread(sum);
            SumThread.Start();
            Thread MaxThread = new Thread(max);
            MaxThread.Start();
            Thread SortArrThread = new Thread(sortarr);
            SortArrThread.Start();
        }
        
        
        
        public static void sum()
        {
            int sum =0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        public static void max()
        {
            int max = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]> max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
        public static void sortarr()
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
        }
    }
}
