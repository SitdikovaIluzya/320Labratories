using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Smirnov.Task_4_
{
    class TaskPrac
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] result = new int[10];
        public static void Start()
        {
            Task task1 = new Task(FillArray);
            Task task2 = new Task(SumTwoArray);
            task1.Start();
            task1.Wait();
            task2.Start();
        }

        static void FillArray()
        {
            Random rnd = new Random();
            Console.Write("First array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(-100, 100);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Second array: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(-100, 100);
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
        }

        static void SumTwoArray()
        {
            Console.Write("Result array: ");
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] + array2[i];
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

