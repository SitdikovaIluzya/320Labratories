using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Tikhonov.tasks
{
    static class Tasks
    {


        private static int[] FirstArray = new int[10];
        private static int[] SecondArray = new int[10];
        private static int[] FinalArray = new int[10];
        public static void tasks()
        {
            Task taskArrGen = Task.Factory.StartNew(() =>      
            {
                arrGen();
                Task taskSumOfElements = Task.Factory.StartNew(() =>
                {
                    sumOfElements();
                }, TaskCreationOptions.AttachedToParent);
            });
            taskArrGen.Wait();
        }
        private static void sumOfElements()
        {

                for (int i = 0; i < FirstArray.Length; i++)
                {
                    FinalArray[i] = FirstArray[i] + SecondArray[i];
                }
                Console.WriteLine("[{0}]", string.Join(", ", FinalArray));
            
        }

        private static void arrGen()
        {
            Random rand = new Random();
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    FirstArray[i] = rand.Next(10);
                    SecondArray[i] = rand.Next(10);
                }
                Console.WriteLine("[{0}]", string.Join(", ", FirstArray));
                Console.WriteLine("[{0}]", string.Join(", ", SecondArray));


            
        }
    }
}
