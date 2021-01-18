using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Hamatullin._2praktik
{
    class StartingThearding
    {

        Object mass1 = new Arrays(new int[] { 1, 10, 15, 2, 40 });
        Object mass2 = new Arrays(new int[] { 100, 10, 25, 20, 1 });
        Object mass3 = new Arrays(new int[] { 40, 30, 25, 20, 10 });

        public static void Start()
        {
            Thread thread1 = new Thread(new ParameterizedThreadStart(MethodsArray.Summa));
            Thread thread2 = new Thread(new ParameterizedThreadStart(MethodsArray.MaxElem));
            Thread thread3 = new Thread(new ParameterizedThreadStart(MethodsArray.SortArray));
        }
    }
    class Arrays
    {
        private int[] array;
        public int[] Array { get; set; }
        public Arrays(int[] Array)
        {
                this.Array = Array;
        }
    }
}
