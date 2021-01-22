using System;
using System.Threading.Tasks;

namespace Laboratories320.Abdrakov.TPL
{
    class TPL2
    {
        private static int[] array = new int[20];
        private static long product = 1;

        public static void PseudoMain()
        {
            Task taskGenerate = new Task(GenerateArray);
            taskGenerate.Start();
            taskGenerate.Wait();
            Task taskProduct = taskGenerate.ContinueWith(prod => FindProduct());
            Task taskPrint = taskProduct.ContinueWith(res => PrintResult());
            taskPrint.Wait();
        }

        private static void GenerateArray()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(1, 10);
                array[i] = random.Next(1, 10);
            }
            Console.WriteLine("Array: [{0}]", string.Join(", ", array));
        }

        private static void FindProduct()
        {
            for (int i = 0; i < array.Length; ++i)
                product *= array[i];
            Console.WriteLine("Product: " + product);
        }

        private static void PrintResult()
        {
            string str = product.ToString();
            Console.Write("Even digits: ");
            foreach (char digit in str)
            {
                int bar = digit - '0';
                if (bar % 2 == 0)
                    Console.Write(bar + " ");
            }
            Console.WriteLine();
        }
    }
}
