using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.task_21._01._21
{
    class Tasks
    {
        static int[] array_1 = new int[10];
        static int[] array_2 = new int[10];
        static int[] array_3 = new int[10];

        static void TasksMain()
        {
            Task task1 = Task.Run(() => Random_Ar());
            task1.Wait();
            Task task2 = new Task(() => Sum());
            task2.Start();
        }
        static void Random_Ar()
        {
            Console.WriteLine("Поток 1");
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array_1[i] = rnd.Next(10);
                array_2[i] = rnd.Next(10);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array_1[i] + ", " + array_2[i]);
            }
        }

        static void Sum()
        {
            Console.WriteLine("Поток 2");
            for (int i = 0; i < 10; i++)
            {
                array_3[i] = array_1[i] + array_2[i];
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array_3[i]);
            }
        }
    }
}
