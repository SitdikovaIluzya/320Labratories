using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.Dyubanov.Threading
{
    class Tasks
    {
        static int[] arrA = new int[10];
        static int[] arrB = new int[10];
        static int[] arrSum = new int[10];

        public void Start()
        {
            Task task1 = new Task(() =>
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    Random rnd = new Random();
                    arrA[i] = rnd.Next(0, 100);
                    arrB[i] = rnd.Next(0, 100);
                }

                Task task2 = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < arrSum.Length; i++)
                    {
                        arrSum[i] = arrA[i] + arrB[i];
                    }
                }, TaskCreationOptions.AttachedToParent);
            });

            task1.Start();
            task1.Wait();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " A = " + arrA[i]);
                Console.WriteLine(i + " B = " + arrB[i]);
                Console.WriteLine(i + " Sum = " + arrSum[i]);
            }
        }
    }
}
