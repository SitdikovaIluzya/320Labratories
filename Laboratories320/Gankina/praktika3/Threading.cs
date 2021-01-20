using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Gankina.praktika3
{
    class Threading
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] array3 = new int[10];
        static object locker = new object();
        public void Start()
        {
            Thread GenThr = new Thread(Generator);
            Thread Gen2Thr = new Thread(Generator2);
            Thread SummaThr = new Thread(Summa);
            GenThr.Start();
            Thread.Sleep(155);
            Gen2Thr.Start();
            SummaThr.Start();
            Thread.Sleep(260);

        }
        public void Generator()
        {
            Random rnd = new Random();
            lock (Threading.locker)
            {
                Console.WriteLine("Первый массив:");
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(15, 150);
                    Console.Write(array1[i] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Generator2()
        {
            Random rnd = new Random();
            lock (Threading.locker)
            {
                Console.WriteLine("Второй массив:");
                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = rnd.Next(-150, 15);
                    Console.Write(array2[i] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Summa()
        {
            lock (locker)
            {
                Console.WriteLine("Сумма элементов массива:");
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] + array2[i];
                    Console.Write(array3[i] + " ");
                }
                Console.WriteLine();




            }

        }
    }
}
