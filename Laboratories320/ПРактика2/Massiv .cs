using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.ПРактика2
{
    class Massiv 
    {
        class Arr
        {
            public int[] array = { -2, 30, -111, 156, 1223 };
        }

        public static void List()
        {
            Arr array = new Arr();
            Thread thread1 = new Thread(Summa);
            Thread thread2 = new Thread(Max);
            Thread thread3 = new Thread(Sort);
            thread1.Start(array);
            thread2.Start(array);
            thread3.Start(array);

        }
        public static void Summa(object obj)
        {
            Arr a = (Arr)obj;
            int[] arr = a.array;
            int Sum = 0;
            foreach (int item in arr)
            {
                Sum += item;
            }
            Console.WriteLine("Sum: " + Sum);
        }

        
        public static void Sort(object obj)
        {
            int[] array = { -2, 30, -111, 156, 1223 };
            Array.Sort(array);
        }

    }
}

