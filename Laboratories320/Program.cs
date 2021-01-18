using System;
using Laboratories320.Lab2;
namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Threading.MaxThread.Start();
            Threading.SumThread.Start();
            Threading.SortThread.Start();
        }
    }
}
