using Laboratories320.Gankina.praktika3;
using Laboratories320.Gankina.Threading;
using System;
using System.Threading;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Threading thr = new Threading();
            thr.Start();
        }
    }
}

