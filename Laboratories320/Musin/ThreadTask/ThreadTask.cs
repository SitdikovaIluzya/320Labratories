using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Musin.ThreadTask
{
    class ThreadTask
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] result = new int[10];

        public static void Start()
        {
            Task task1 = new Task(() => Generate());
            Task task2 = new Task(() => Summ());
            task1.Start();
            task1.Wait();
            task2.Start();
        }
        public static void Generate()
        {
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1,10);
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1,10);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Summ()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] + array2[i];
                Console.Write(result[i] + " ");
            }
        }
    }
}
