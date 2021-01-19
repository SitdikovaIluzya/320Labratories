using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Zakirov._2Thread
{
    class Threadingg
    {
        public static void Start()
        {
            Thread thread1 = new Thread(ThreeMethods.Sum);
            Thread thread2 = new Thread(ThreeMethods.Max);
            Thread thread3 = new Thread(ThreeMethods.Sort);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
