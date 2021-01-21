using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.ContinuationTasks
{
    class ContinTasks
    {
        static int[] array = new int[20];
        static int result = 1;
        public static void Generator()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 5);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Multiplier()
        {
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            Console.WriteLine(result);
        }
    }
}
