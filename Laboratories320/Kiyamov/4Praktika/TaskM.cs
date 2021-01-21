using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Laboratories320.Kiyamov._4Praktika
{
    class TaskM
    {
        static Object locker = new object();
        static int[] Massive1 = new int[10];
        static int[] Massive2 = new int[10];
        static int[] resuilt = new int[10];

        public static void Start()
        {
            Task task1 = new Task(MassiveGenerate);
            Task task2 = new Task(MassiveSum);
            task1.Start();
            task1.Wait();
            task2.Start();
            task2.Wait();
        }


        public static void MassiveGenerate()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < Massive1.Length; i++)
                {
                    Massive1[i] = rnd.Next(10, 20);
                    Massive2[i] = rnd.Next(10, 20);
                }
            }
        }

        public static void MassiveSum()
        {

            {
                lock (locker)
                {
                    Console.Write("Sum:  ");
                    for (int i = 0; i < resuilt.Length; i++)
                    {
                        resuilt[i] = Massive1[i] + Massive2[i];
                    }
                    foreach (var item in resuilt)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
