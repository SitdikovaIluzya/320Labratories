
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace Laboratories320.Mazitova.Pr5
{
    class ContinuationTasks
    {
        int[] array = new int [20];
        Random random = new Random();
        public void Start()
        {
            Task task1 = new Task(GetGenNum);
            Task<int> task2 = task1.ContinueWith(a => Product());
            Task task3 = task2.ContinueWith(a => Parity(task2.Result));
            task1.Start();
            task3.Wait();
        }

        void GetGenNum()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 9);
            }

            Console.Write("Элементы массива: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
       
        int Product()
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine("Проивзедение всех элементов: " + product);
            return product;
        }

        void Parity(int number)
        {
            Console.WriteLine("Чётная цифра: ");

            string num = number.ToString();
            int[] a = new int[num.Length];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(num[i].ToString());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i] + " ");
                }
            }
        }
    }
}
