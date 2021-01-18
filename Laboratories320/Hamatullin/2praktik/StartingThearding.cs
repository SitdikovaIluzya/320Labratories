using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Hamatullin._2praktik
{
    class StartingThearding
    {

        MethodsArray mass1 = new MethodsArray(new int[] { 1, 10, 15, 2, 40 });
        MethodsArray mass2 = new MethodsArray(new int[] { 100, 10, 25, 20, 1 });
        MethodsArray mass3 = new MethodsArray(new int[] { 40, 30, 25, 20, 10 });
        public static void Start()
        {
            Thread thread1 = new Thread(mass1.MaxElem());
        }
    }
}
