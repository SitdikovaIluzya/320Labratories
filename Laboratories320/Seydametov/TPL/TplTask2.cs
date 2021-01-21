using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Seydametov.TPL
{
    class TplTask2
    {
        static int[] arr = new int[20];
        static long sum = 1;


        public static void Start()
        {
            Task task1 = new Task(Random);
            task1.Start();
            task1.Wait();
            Task task2 = task1.ContinueWith(pro => Product());
            Task task3 = task2.ContinueWith(res => Result());
            task3.Wait();


        }
        static void Random()
        {
            Random rand = new Random();
            for (int y = 0; y < arr.Length; y++)
            {
                arr[y] = rand.Next(1, 10);
                arr[y] = rand.Next(1, 10);
                Console.WriteLine(arr[y]);
            }
            
        }
        static void Product()
        {
            for (int i = 0; i < arr.Length; i++)
                sum *= arr[i];
            Console.WriteLine("Product: " + sum);  
        }

        static void Result()
        {
            String str = sum.ToString();
            long num = 0;
            long a = 0;
            Console.Write("even: ");
            for(int i = 0; i < str.Length; i++)
            {
                num = sum % 10;
                sum = sum / 10;
                a = num;
                if(a % 2 == 0)
                {
                    Console.Write(num);
                }
            }   
        }
    }
}
