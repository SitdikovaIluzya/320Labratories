using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Seydametov.TPL
{
    class Tpl
    {
        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] sum = new int[10];
        public static void tpl()
        {
            Task task1 = new Task(Random);
            task1.Start();
            task1.Wait();
            for (int y = 0; y < arr1.Length; y++)
            {
                Console.WriteLine("1 массив " + arr1[y]);
                Console.WriteLine("2 массив " + arr2[y]);
                Console.WriteLine("Sum " + sum[y]);
            }
        }

        static void Random()
        {

            Random rand = new Random();
            for (int y = 0; y < arr1.Length; y++)
            {
                arr1[y] = rand.Next(1, 20);
                arr2[y] = rand.Next(1, 20);
            }
            Task task2 = new Task(Sum, TaskCreationOptions.AttachedToParent);
            task2.Start();
        }

        public static void Sum()
        {
             for (int i = 0; i < sum.Length; i++)
             {
                sum[i] = arr1[i] + arr2[i];
             }
        }
    }
}
