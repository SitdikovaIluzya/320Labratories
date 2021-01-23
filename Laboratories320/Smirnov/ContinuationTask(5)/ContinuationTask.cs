using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Smirnov.ContinuationTask_5_
{
    class ContinuationTask
    {
        //найти произведение всех элементов,
        //и получите только четные цифры из результата.
        //Создайте правильную последовательность задач продолжения.
        static int[] arr = new int[20];
        static int product = 1;

        public static void Begin()
        {
            Task taskFillArray = new Task(Generate);
            taskFillArray.Start();
            taskFillArray.Wait();
            Task prArr = new Task(Product);
            prArr.Start();
            prArr.Wait();
            Task findEven = new Task(Even);
            findEven.Start();
            findEven.Wait();
        }
        static void Generate()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }

        static void Product()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine("Произведение: " + product);
        }

        static void Even()
        {
            string even = "";
            string emp = product.ToString();
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i] % 2 == 0)
                {
                    even += emp[i] + " ";
                }
            }
            Console.Write("Четные цифры: " + even);
        }
    }
}
