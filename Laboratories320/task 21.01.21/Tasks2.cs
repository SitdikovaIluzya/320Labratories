using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.task_21._01._21
{
    class Tasks2
    {
        static int[] array = new int[20];
        static int prod = 1;

        static void TaskTwoMain()
        {
            Task task1 = new Task(() => Random_Ar());
            task1.Start();
            Task task2 = task1.ContinueWith(Product);
            task2.Wait();
            Task task3 = task2.ContinueWith(EvenDigits);
            task3.Wait();
        }


        static void Random_Ar()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 5);
            }
            Console.WriteLine("Массив = " + String.Join(", ", array));
        }

        static void Product(Task t)
        {
            for (int i = 0; i < 20; i++)
            {
                prod *= array[i];
            }
            Console.WriteLine("Произведение = " + prod);
        }

        static void EvenDigits(Task t)
        {
            string chars = prod.ToString();
            List<int> result = new List<int> { };
            for (int i = 0; i < chars.Length; i++)
            {
                int a = Convert.ToInt32(new string(chars[i], 1));
                if (a % 2 == 0)
                {
                    result.Add(a);
                }
            }
            Console.WriteLine("Цифры = " + String.Join(", ", result));
        }
    }
}
