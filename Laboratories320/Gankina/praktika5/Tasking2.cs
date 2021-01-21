using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Gankina.praktika5
{
    class Tasking2
    {
        static object locker = new object();
        static int[] arr = new int[20];

        public void Start()
        {
            Task task = new Task(Generator);
            Task task2 = task.ContinueWith(mul => Multiplication());
            task.Start();
            task2.Wait();
            Task task3 = task2.ContinueWith(even => GetEven());

        }

        public void Generator()
        {

            Random rnd = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 100);
                Console.WriteLine(arr[i]);
            }
        }

        public void Multiplication()
        {
            int result = 1;
            Console.WriteLine("Произведение элементов массива");
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];

            }
            Console.WriteLine(result);
        }

        public static void GetEven()
        {
            Console.WriteLine("Четные цифры массива");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}