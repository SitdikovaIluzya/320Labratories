using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Dyubanov.Threading

{
    class ContinuationTasks
    {
        static int[] arr = new int[20];
        static int product = 1;

        public void Start()
        {
            Task task1 = Task.Factory.StartNew(() => generation());
            Task task2 = task1.ContinueWith(mul => multiply());
            Task task3 = task2.ContinueWith(even => getEven());
            task3.Wait();
        }

        private void generation()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Random rnd = new Random();
                arr[i] = rnd.Next(1, 20);
                Console.WriteLine(i + " " + arr[i]);
            }
        }

        private void multiply()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }
            Console.WriteLine("Product = " + product);
        }

        private void getEven()
        {
            String str = product.ToString();
            Console.Write("Even digits = ");
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] % 2 == 0)
                {
                    Console.Write(str[i]);
                }
            }
        }
    }
}
