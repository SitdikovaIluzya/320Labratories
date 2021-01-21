using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Pract3
{
    class ThreadLocker
    {
        static int[] num1 = new int[10];
        static int[] num2 = new int[10];
        static int[] resl = new int[10];
        static object locker = new object();

        public static void Starting()
        {
            Thread thr1 = new Thread(Generate);
            Thread thr2 = new Thread(Summa);
            thr1.Start();
            thr2.Start();
        }

        public static void Generate()
        {
            lock (locker)
            {
                Random rand = new Random();
                for (int i = 0; i < num1.Length; i++)
                {
                    num1[i] = rand.Next(10);
                    Console.WriteLine(num1[i] + " ");
                }

                for (int i = 0; i < num2.Length; i++)
                {
                    num2[i] = rand.Next(10);
                    Console.WriteLine(num2[i] + " ");
                }

            }
        }
            
            public static void Summa()
            {
                Thread.Sleep(100);
                for (int i = 0; i < resl.Length; i++)
                {
                    resl[i] = num1[i] + num2[i];
                    Console.WriteLine(resl[i] + " ");

                }
            }
        }



    }

