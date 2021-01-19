using Laboratories320.Dyubanov.StrategyGame;
using Laboratories320.Dyubanov.Threading;
using System;
using System.Threading;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Locker locker = new Locker();
            locker.Start();
        }
    }
}
