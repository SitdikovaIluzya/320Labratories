using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Saifetdinov.Prak2
{
    class Theading
    {
        public static void Thread()
        {
            Thread thread1 = new Thread(MethodsSumSortMax.Summa);
            Thread thread2 = new Thread(MethodsSumSortMax.MaxElementArray);
            Thread thread3 = new Thread(MethodsSumSortMax.SortElemntsArray);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
