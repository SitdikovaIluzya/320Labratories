using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Kiyamov.Thread
{
    class StartThreading
    {
        private static object MethodsArray;

        public static void Start()
        {
            Methods mass1 = new Methods(new int[] { 1, 10, 15, 2, 40 });
            Methods mass2 = new Methods(new int[] { 100, 10, 25, 20, 1 });
            Methods mass3 = new Methods(new int[] { 40, 30, 25, 20, 10 });
            Methods thread1 = new Methods(new ParameterizedThreadStart(MethodsArray.SumArray));
            Methods thread2 = new Methods(new ParameterizedThreadStart(MethodsArray.MaxElement));
            Methods thread3 = new Methods(new ParameterizedThreadStart(MethodsArray.Sorting));
            thread1.Start(mass1);
            thread2.Start(mass2);
            thread3.Start(mass3);
        }
    }
}
