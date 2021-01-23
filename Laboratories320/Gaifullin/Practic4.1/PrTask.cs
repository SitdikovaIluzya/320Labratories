using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.Gaifullin
{
    class PrTask
    {
        public static int[] array1 = new int[20];
        public static int[] array2 = new int[20];
        public static int[] array3 = new int[20];

        static object Multiplication = new object();
        static object Generator = new object();

        public static void ThTasks()
        {
            Task task1 = new Task(() => Generatorr());
            Task task2 = Task.Run(() => Multiplicationn());
            task1.Start();
            task2.Wait();
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("[{0}]", string.Join(", ", array3));
        }

        public static void Multiplicationn()
        {

            for (int i = 0; i < 5; i++)
            {
                array3[i] = array1[i] * array2[i];
            }
            Console.WriteLine("Multiplicationn:");
        }
        public static void Generatorr()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                array1[i] = rnd.Next(-10, 10);
                array2[i] = rnd.Next(-10, 10);
            }
            Console.WriteLine("Generating:");

        }
        


    }
}
