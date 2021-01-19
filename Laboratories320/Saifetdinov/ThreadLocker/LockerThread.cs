using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratories320.Saifetdinov.ThreadLocker
{
    class LockerThread
    {
        public static void Threading()
        {
            Thread thread1 = new Thread(Methods.GenerationElments);
            Thread thread2 = new Thread(Methods.SummaArray);
            thread1.Start();
            thread2.Start();
        }
    }
}
