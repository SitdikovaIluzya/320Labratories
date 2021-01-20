using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Lab3
{
    
    class Threading2
    {
        static object locker = new object();
        public int[] Array1 { get; set; }
        public int[] Array2 { get; set; }

        public int[] array;
        public Threading2(int[] array1, int[] array2)
        {
            this.Array1 = array1;
            this.Array2 = array1;
        }

        public void Start()
        {
            Thread GenThr = new Thread(Generator);
            Thread SumThr = new Thread(Sum);
            SumThr.Start();
            Thread.Sleep(100);
            GenThr.Start();

            
        }
        public void Generator()
        {
            lock (locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < Array1.Length && i < Array2.Length; i++)
                {
                    Array1[i] = rnd.Next(-10, 100);
                    Array2[i] = rnd.Next(-20, 50);
                }
            }
        }

        public void Sum()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Array1[1] + Array2[i];
            }
        }
    }
}
