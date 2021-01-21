using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.Zakirov._5ContinuationTasks
{
    class ConTasks
    {
        static int[] numbers = new int[20];
        static int result = 1;

        public static void Generator()
        {
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 5);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
            
        public static void FindNumber()
        {
            Thread.Sleep(100);
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            Console.Write(result);
            Console.WriteLine();
        }

        public static void Parity()
        {
            while (result > 10)
            {
                if (result % 2 == 0)
                {
                    string numb = result.ToString();
                    Console.Write("|" + numb[numb.Length - 1] + "|");
                }
                result /= 10;
            }
            if (result % 2 == 0)
            {
                Console.Write(result);
            }
        }

        public static void Task()
        {
            Task task1 = new Task(Generator);
            Task task2 = new Task(FindNumber);
            Task task3 = task2.ContinueWith(parit => Parity());
            task1.Start();
            task2.Start();
            task3.Wait();
        }
    }
}
