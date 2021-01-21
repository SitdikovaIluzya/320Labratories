using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Mazitova.Pr4
{
    class ThreadLockerTask
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] array3 = new int[10];

        static object locker = new object();

        public void GetArray()
        {
            lock (locker)
            {
                Console.WriteLine("-------------");
                Console.WriteLine();
                Console.WriteLine("First array");
                Random random = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = random.Next(-100, 100);
                }

                foreach (var it in array1)
                {
                    Console.WriteLine(it + " ");
                }
            }
            lock (locker)
            {
                Console.WriteLine("-------------");
                Console.WriteLine();
                Console.WriteLine("Second array");
                Random random = new Random();
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = random.Next(-100, 100);
                }

                foreach (var it in array2)
                {
                    Console.WriteLine(it + " ");
                }
            }

        }
        public void Start()
        {
            Task GetArr = new Task(GetArray);
            Task SummaT = new Task(Summa);

            
            
          
            Task.Run(() => Summa());
            Task.Run(() => GetArray());
            SummaT.Wait();


        }

        public void Summa()
        {
            lock (locker)
            {
                Console.WriteLine("-------------");
                Console.WriteLine();
                Console.WriteLine("Sum arrays");
                for (int i = 0; i < array1.Length && i < array2.Length; i++)
                {
                    array3[i] = array1[1] + array2[i];
                }

                foreach (var item in array3)
                {
                    Console.WriteLine(item + " ");
                }
            }

        }
    }
}
