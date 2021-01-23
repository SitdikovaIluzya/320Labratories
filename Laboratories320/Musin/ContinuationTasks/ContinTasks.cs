using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            Thread.Sleep(100);
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            Console.WriteLine(result);
            Console.WriteLine();
        }

        public static void Parity()
        {
            while (result > 10)
            {
                if (result % 2 == 0)
                {
                    string arr = result.ToString();
                    Console.Write("|" + arr[arr.Length - 1] + "|");
                }
                result /= 10;
            }
            if (result % 2 == 0)
            {
                Console.Write(result);
            }
        }

        public static void Start()
        {
            Task task1 = new Task(Generator);
            Task task2 = new Task(Multiplier);
            Task task3 = task2.ContinueWith(parity => Parity());
            task1.Start();
            task2.Start();
            task3.Wait();
        }
    }
}
