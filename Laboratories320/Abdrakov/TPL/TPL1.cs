using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Abdrakov.TPL
{
    class TPL1
    {
        private static int[] array1 = new int[10];
        private static int[] array2 = new int[10];
        private static int[] sumArray = new int[10];

        public static void PseudoMain()
        {
            Task task = new Task(RandomFillArray);
            task.Start();
            task.Wait();
            Console.WriteLine("Array 1: [{0}]", string.Join(", ", array1));
            Console.WriteLine("Array 2: [{0}]", string.Join(", ", array2));
            Console.WriteLine("Sum of arrays: [{0}]", string.Join(", ", sumArray));
        }

        private static void RandomFillArray()
        {
            Random random = new Random();
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = random.Next(1, 20);
                array2[i] = random.Next(1, 20);
            }
            Task task = new Task(SumOfArray, TaskCreationOptions.AttachedToParent);
            task.Start();
        }

        private static void SumOfArray()
        {
            for (int i = 0; i < sumArray.Length; ++i)
            {
                sumArray[i] = array1[i] + array2[i];
            }
        }
    }
}
