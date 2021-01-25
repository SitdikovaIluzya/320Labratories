using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Seydametov.Parallel
{
    class Program
    {
        static void Parallel()
        {
            Parallel.Invoke(sum, mul, div);
        }
        static void sum()
        {
            Console.WriteLine(5 + 9);
        }

        static void mul()
        {
            Console.WriteLine(5 * 9);

        }

        static void div()
        {
            Console.WriteLine();
        }
    }
}
