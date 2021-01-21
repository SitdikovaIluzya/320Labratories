using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Zakirov._4ThreadTask
{
    class ThTask
    {
        static int[] numbers1 = new int[10];
        static int[] numbers2 = new int[10];
        static int[] result = new int[10];

        public static void Tasks()
        {
            Task task1 = new Task(() => Generator());
            Task task2 = new Task(() => Sum());
            task1.Start();
            task1.Wait();
            task2.Start();
        }

        public static void Generator()
        {
                Random rnd = new Random();
                for (int i = 0; i < numbers1.Length; i++)
                {
                    numbers1[i] = rnd.Next(1, 9);
                    Console.Write(numbers1[i] + " ");
                }

                Console.WriteLine();

                for (int i = 0; i < numbers2.Length; i++)
                {
                    numbers2[i] = rnd.Next(1, 9);
                    Console.Write(numbers2[i] + " ");
                }
                Console.WriteLine();
        }

        public static void Sum()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numbers1[i] + numbers2[i];
                Console.Write(result[i] + " ");
            }
        }
    }

}
