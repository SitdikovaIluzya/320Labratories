using Laboratories320.Mazitova.Pr3;
using System;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here...");
            Console.WriteLine();

            ThreadLocker thr = new ThreadLocker();
            thr.Start();

        }
    }
}
