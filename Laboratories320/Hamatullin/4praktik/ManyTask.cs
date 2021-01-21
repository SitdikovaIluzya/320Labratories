using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Hamatullin._4praktik
{
    class ManyTask
    {
        static int[] mass1 = new int[10];
        static int[] mass2 = new int[10];
        static int[] result = new int[10];

        public static void Start()
        {
            Task task1 = new Task(GenerateMass);
            Task task2 = new Task(Sum);
            task1.Start();
            task1.Wait();
            task2.Start();
            task2.Wait();
        }
        public static void GenerateMass()
        {
            Random rnd = new Random();
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(10, 20);
                mass2[i] = rnd.Next(10, 20);
            }
        }
        public static void Sum()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = mass1[i] + mass2[i];
                Console.Write(result[i] + " ");
            }
        }
    }
}
