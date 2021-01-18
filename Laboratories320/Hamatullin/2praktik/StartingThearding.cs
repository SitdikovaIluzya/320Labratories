using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Hamatullin._2praktik
{
    class StartingThearding
    {

        public static void Start()
        {
            Massive massive1 = new Massive(new int[] { 1, 10, 15, 2, 40 });
            Massive massive2 = new Massive(new int[] { 100, 10, 25, 20, 1 });
            Massive massive3 = new Massive(new int[] { 40, 30, 25, 20, 10 });
            Thread thread1 = new Thread(new ParameterizedThreadStart(MethodsArray.Summa));
            Thread thread2 = new Thread(new ParameterizedThreadStart(MethodsArray.MaxElem));
            Thread thread3 = new Thread(new ParameterizedThreadStart(MethodsArray.SortArray));
            thread1.Start(massive1.Array);
            thread2.Start(massive2.Array);
            thread3.Start(massive3.Array);
        }
    }
    class Massive
    {
        public int[] Array { get; set; }
        public Massive(int[] Array)
        {
            this.Array = Array;
        }
    }
}
