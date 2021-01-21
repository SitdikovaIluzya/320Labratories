using System;
using Laboratories320.Zakirov._2Thread;
using Laboratories320.Zakirov._3ThreadLocker;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() => Console.WriteLine("*"));
            task1.Start();
            Task task2 = Task.Run(() => Console.WriteLine("#"));
            task1.Wait();
            task2.Wait();
        }
    }
}
