using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Pract2
{
    static class Thread
  
    {
        public static void Sum(int[] mass)
        {
            int[] array = { 4, 7, 15, 32, 11, 3 };
            int sum = 0;
            for(int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                    sum += mass[i];
            }
            Console.WriteLine();
            Console.WriteLine($"sum: {sum}");
            
            
        }

        public static void Max (int [] mass)
        {
            int[] array = { 4, 7, 15, 32, 11, 3 };
            int b = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (b > mass[i])
                {
                    b = mass[b];
                }
                Console.WriteLine(b);
            }


             static void Sort (int[] mass)
            {
                int[] array = { 4, 7, 15, 32, 11, 3 };
                Array.Sort(mass);
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine($"{mass[i]}");
                }
            }
    }
    }
}
