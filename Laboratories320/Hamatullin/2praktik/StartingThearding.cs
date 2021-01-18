using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Hamatullin._2praktik
{
    class StartingThearding
    {

        Arrays mass1 = new Arrays(new int[] { 1, 10, 15, 2, 40 });
        Arrays mass2 = new Arrays(new int[] { 100, 10, 25, 20, 1 });
        Arrays mass3 = new Arrays(new int[] { 40, 30, 25, 20, 10 });
        public static void Start()
        {
            Thread thread1 = new Thread();
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
