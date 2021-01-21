using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Lab4
{
    class Tasking
    {
        static object locker = new object();
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] array = new int[10];
        public void Start()
        {
            Task GenThr = new Task(Generator);
            Task SumThr = new Task(Sum);
            GenThr.Start();
            GenThr.Wait();
            SumThr.Start();
            SumThr.Wait();

        }
        public void Generator()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(-10, 100);
                }
                Console.WriteLine("Первый массив");
                foreach (var it in array1)
                {
                    Console.WriteLine(it + " ");
                }
            }
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rnd.Next(-10, 100);
                }

                Console.WriteLine("Второй массив");
                foreach (var it in array2)
                {
                    Console.WriteLine(it + " ");
                }
            }


        }

        public void Sum()
        {
            lock (locker)
            {
                for (int i = 0; i < array1.Length && i < array2.Length; i++)
                {
                    array[i] = array1[1] + array2[i];
                }
                Console.WriteLine("Сумма двух массивов");
                foreach (var item in array)
                {
                    Console.WriteLine(item + " ");
                }
            }
        }
    }
}
